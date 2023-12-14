using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ICT_PROJECT_E2140154
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bubble Tea Shop", new Font("Monotype Corsiva", 30, FontStyle.Italic), Brushes.Black, new Point(250));
            e.Graphics.DrawString("Wakwella Road, Kalegana Galle", new Font("Monotype Corsiva", 20, FontStyle.Bold), Brushes.Black, new Point(260, 70));
            e.Graphics.DrawString("Tel. No: 091-7924235", new Font("Monotype Corsiva", 20, FontStyle.Bold), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("Invoice", new Font("Palatino Linotype", 20, FontStyle.Italic), Brushes.Black, new Point(350, 140));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("alatino Linotype", 18, FontStyle.Italic), Brushes.Black, new Point(0, 170));

            for (int i = 0; i < 1; i++)
            {
                String O_date = dgvOrderManagement.Rows[i].Cells[1].Value.ToString();
                e.Graphics.DrawString("Order Date : " + O_date, new Font("Palatino Linotype", 18, FontStyle.Italic), Brushes.Black, new Point(10, 190));
            }

            double sum = 0;
            int k = 50;
            double dis = 0;
            double subtotal = 0;

            e.Graphics.DrawString("Item Code   Item Name               Item Price     Item Quantity     Amount", new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Palatino Linotype", 18, FontStyle.Italic), Brushes.Black, new Point(0, 260));


            for (int i = 0; i <= dgvOrderManagement.Rows.Count - 1; i++)


            {
                string I_Code = string.Empty;
                string I_Name = string.Empty;
                string I_Category = string.Empty;



                if (dgvOrderManagement.Rows[i].Cells[2].Value != null)
                {
                    I_Code = dgvOrderManagement.Rows[i].Cells[2].Value.ToString();
                }
                else
                {

                    I_Code = " ";
                }

                if (dgvOrderManagement.Rows[i].Cells[3].Value != null)
                {
                    I_Name = dgvOrderManagement.Rows[i].Cells[3].Value.ToString();
                }
                else
                {

                    I_Name = " ";

                }

                if (dgvOrderManagement.Rows[i].Cells[4].Value != null)
                {
                    I_Category = dgvOrderManagement.Rows[i].Cells[4].Value.ToString();
                }
                else
                {

                    I_Category = " ";
                }

                
                if (dgvOrderManagement.Rows[i].Cells[5].Value != null && dgvOrderManagement.Rows[i].Cells[6].Value != null)
                {
                    int I_Price = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[5].Value);


                    int I_Quantity = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[6].Value);
                    

                    int total = I_Price * I_Quantity;
                    e.Graphics.DrawString(I_Code + "                 " + I_Name + " - " + I_Category + "           Rs. " + I_Price + "                 " + I_Quantity + "                      Rs. " + total, new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new Point(10, (260 + k)));

                    k = k + 50;
                }
                else
                {

                    Console.WriteLine(" ");




                    continue;
                }

            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Palatino Linotype", 18, FontStyle.Italic), Brushes.Black, new Point(0, 730));

            for (int i = 0; i < dgvOrderManagement.Rows.Count; i++)
            {
                if (dgvOrderManagement.Rows[i].Cells[8].Value != null && dgvOrderManagement.Rows[i].Cells[9].Value != null)
                {
                    double t_discount = Convert.ToDouble(dgvOrderManagement.Rows[i].Cells[8].Value.ToString());
                    double TotalPrice = Convert.ToDouble(dgvOrderManagement.Rows[i].Cells[9].Value.ToString());
                    dis = dis + t_discount;
                    sum = sum + TotalPrice;
                    subtotal = sum + dis;

                }
                else
                {

                    double t_discount = 0.0;
                    double TotalPrice = 0.0;





                    continue;
                }

            }
            e.Graphics.DrawString("Sub Total : Rs. " + subtotal, new Font("Palatino Linotype", 16, FontStyle.Regular), Brushes.Black, new Point(260, 750));
            e.Graphics.DrawString("Discount Total : Rs. " + dis, new Font("Palatino Linotype", 16, FontStyle.Regular), Brushes.Black, new Point(260, 800));
            e.Graphics.DrawString("Grand Total : Rs. " + sum, new Font("Palatino Linotype", 20, FontStyle.Bold), Brushes.Black, new Point(260, 850));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Palatino Linotype", 18, FontStyle.Italic), Brushes.Black, new Point(0, 870));
            e.Graphics.DrawString("Thank You! ", new Font("Monotype Corsiva", 20, FontStyle.Bold), Brushes.Black, new Point(350, 950));


        }

        private void bill_Load(object sender, EventArgs e)
        {
            populate();

            fillCategory();
            txtOrderNumber.Enabled = true;
            txtItmCode.Enabled = true;
            txtItmName.Enabled = true;
            txtItmCategory.Enabled = true;
            txtItmPrice.Enabled = true;
        }
        void fillCategory()
        {
            string query = "select * from CatTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Cat_name", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbSelectCategory.ValueMember = "Cat_name";
                cmbSelectCategory.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from itemTbl ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvItemManagement.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void filterByCategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from itemTbl where item_category='" + cmbSelectCategory.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvItemManagement.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Enabled = true;
            txtOrderNumber.Text = "";
            dtOrderDate.Value = DateTime.Now;
            txtItmCode.Text = "";
            txtItmName.Text = "";
            txtItmCategory.Text = "";
            txtItmPrice.Text = "";
            txtItmQuantity.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderNumber.Text == "")
                {
                    MessageBox.Show("Enter the Order Number");
                }
                else
                {
                    Con.Open();
                    int price;
                    double discount;
                    int quantity;
                    int.TryParse(txtItmPrice.Text, out price);
                    double.TryParse(dgvItemManagement.SelectedRows[0].Cells[4].Value.ToString(), out discount);
                    int.TryParse(txtItmQuantity.Text, out quantity);
                    double tot_dis = discount * quantity;
                    double total = (price - discount) * quantity;
                    SqlCommand cmd = new SqlCommand("insert into billingTbl values('" + txtOrderNumber.Text + "','" + dtOrderDate.Value.ToString() + "','" + txtItmCode.Text + "','" + txtItmName.Text + "','" + txtItmCategory.Text + "','" + txtItmPrice.Text + "','" + txtItmQuantity.Text + "','" + discount + "','" + tot_dis + "','" + total + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvOrderManagement.Rows.Add(txtOrderNumber.Text, dtOrderDate.Text, txtItmCode.Text, txtItmName.Text, txtItmCategory.Text, price, quantity, discount, tot_dis, total);
                    double sum = 0;
                    for (int i = 0; i <= dgvOrderManagement.Rows.Count - 1; i++)
                    {
                        double TotalPrice = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[9].Value);
                        sum = sum + TotalPrice;
                    }
                    lblTotalAmount.Text = "Rs. " + sum.ToString();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
            txtOrderNumber.Text = "";
            dtOrderDate.Value = DateTime.Now;
            txtItmCode.Text = "";
            txtItmName.Text = "";
            txtItmCategory.Text = "";
            txtItmPrice.Text = "";
            txtItmQuantity.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                int price;
                int discount;
                int quantity;
                int.TryParse(txtItmPrice.Text, out price);
                int.TryParse(dgvOrderManagement.SelectedRows[0].Cells[7].Value.ToString(), out discount);
                int.TryParse(txtItmQuantity.Text, out quantity);
                int tot_dis = discount * quantity;
                int total = (price - discount) * quantity;
                SqlCommand cmd = new SqlCommand("update billingTbl set ItemCode = '" + txtItmCode.Text + "', ItemName = '" + txtItmName.Text + "', CategoryName = '" + txtItmCategory.Text + "',ItemPrice = '" + txtItmPrice.Text + "', ItemQuantity = '" + txtItmQuantity.Text + "', DiscountAmount = '" + tot_dis + "', Ttotal = '" + total + "' where OderNumber = '" + txtOrderNumber.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row;
                int length;
                int sum = 0;
                length = dgvOrderManagement.SelectedRows.Count;
                for (int i = length - 1; i >= 0; i--)
                {
                    row = dgvOrderManagement.SelectedRows[i];
                    dgvOrderManagement.Rows.Remove(row);
                }
                this.dgvOrderManagement.Rows.Add(txtOrderNumber.Text, dtOrderDate.Text, txtItmCode.Text, txtItmName.Text, txtItmCategory.Text, price, quantity, discount, tot_dis, total);

                for (int i = 0; i <= dgvOrderManagement.Rows.Count - 1; i++)
                {
                    int TotalPrice = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[9].Value);
                    sum = sum + TotalPrice;
                }
                lblTotalAmount.Text = "Rs. " + sum.ToString();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "")
            {
                MessageBox.Show("Enter the Order Number", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                string myquery = "delete from billingTbl where OderNumber = '" + txtOrderNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row;
                int length;
                int sum = 0;
                length = dgvOrderManagement.SelectedRows.Count;
                for (int i = length - 1; i >= 0; i--)
                {
                    row = dgvOrderManagement.SelectedRows[i];
                    dgvOrderManagement.Rows.Remove(row);
                }
                for (int i = 0; i <= dgvOrderManagement.Rows.Count - 1; i++)
                {
                    int TotalPrice = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[9].Value);
                    sum = sum + TotalPrice;
                }
                lblTotalAmount.Text = "Rs. " + sum.ToString();
                Con.Close();
            }
            txtOrderNumber.Text = "";
            dtOrderDate.Value = DateTime.Now;
            txtItmCode.Text = "";
            txtItmName.Text = "";
            txtItmCategory.Text = "";
            txtItmPrice.Text = "";
            txtItmQuantity.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void dgvOrderManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderNumber.Enabled = false;
            txtOrderNumber.Text = dgvOrderManagement.SelectedRows[0].Cells[0].Value.ToString();
            dtOrderDate.Text = dgvOrderManagement.SelectedRows[0].Cells[1].Value.ToString();
            txtItmCode.Text = dgvOrderManagement.SelectedRows[0].Cells[2].Value.ToString();
            txtItmName.Text = dgvOrderManagement.SelectedRows[0].Cells[3].Value.ToString();
            txtItmCategory.Text = dgvOrderManagement.SelectedRows[0].Cells[4].Value.ToString();
            txtItmPrice.Text = dgvOrderManagement.SelectedRows[0].Cells[5].Value.ToString();
            txtItmQuantity.Text = dgvOrderManagement.SelectedRows[0].Cells[6].Value.ToString();
            Con.Close();
        }

        private void dgvOrderManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderNumber.Text = dgvOrderManagement.SelectedRows[0].Cells[0].Value.ToString();
            dtOrderDate.Text = dgvOrderManagement.SelectedRows[0].Cells[1].Value.ToString();
            txtItmCode.Text = dgvOrderManagement.SelectedRows[0].Cells[2].Value.ToString();
            txtItmName.Text = dgvOrderManagement.SelectedRows[0].Cells[3].Value.ToString();
            txtItmCategory.Text = dgvOrderManagement.SelectedRows[0].Cells[4].Value.ToString();
            txtItmPrice.Text = dgvOrderManagement.SelectedRows[0].Cells[5].Value.ToString();
            txtItmQuantity.Text = dgvOrderManagement.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dgvItemManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItmCode.Text = dgvItemManagement.SelectedRows[0].Cells[0].Value.ToString();
            txtItmName.Text = dgvItemManagement.SelectedRows[0].Cells[1].Value.ToString();
            txtItmPrice.Text = dgvItemManagement.SelectedRows[0].Cells[2].Value.ToString();
            txtItmCategory.Text = dgvItemManagement.SelectedRows[0].Cells[3].Value.ToString();
            Con.Close();
        }

        private void dgvItemManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItmCode.Text = dgvItemManagement.SelectedRows[0].Cells[0].Value.ToString();
            txtItmName.Text = dgvItemManagement.SelectedRows[0].Cells[1].Value.ToString();
            txtItmPrice.Text = dgvItemManagement.SelectedRows[0].Cells[2].Value.ToString();
            txtItmCategory.Text = dgvItemManagement.SelectedRows[0].Cells[3].Value.ToString();
            Con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewSales vs = new ViewSales();
            vs.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populatebill()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from billingTbl ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvOrderManagement.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
