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
    public partial class frm_Item : Form
    {
        public frm_Item()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void frm_Item_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code.Text = dgv_item.SelectedRows[0].Cells[0].Value.ToString();
            txt_iname.Text = dgv_item.SelectedRows[0].Cells[1].Value.ToString();
            txt_price.Text = dgv_item.SelectedRows[0].Cells[2].Value.ToString();
            cmbItemCategory.SelectedValue = dgv_item.SelectedRows[0].Cells[3].Value.ToString();
            txt_disc.Text = dgv_item.SelectedRows[0].Cells[4].Value.ToString();
            txt_code.Enabled = false;

        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code.Text = dgv_item.SelectedRows[0].Cells[0].Value.ToString();
            txt_iname.Text = dgv_item.SelectedRows[0].Cells[1].Value.ToString();
            txt_price.Text = dgv_item.SelectedRows[0].Cells[2].Value.ToString();
            cmbItemCategory.SelectedValue = dgv_item.SelectedRows[0].Cells[3].Value.ToString();
            txt_disc.Text = dgv_item.SelectedRows[0].Cells[4].Value.ToString();
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
                cmbItemCategory.ValueMember = "Cat_name";
                cmbItemCategory.DataSource = dt;
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
                dgv_item.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Inew_Click(object sender, EventArgs e)
        {
            txt_code.Enabled = true;
            txt_code.Text = "";
            txt_iname.Text = "";
            txt_price.Text = "";
            txt_disc.Text = "";
            cmbItemCategory.SelectedIndex = 0;
        }

        private void btn_Iadd_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Enter the Item code", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into itemTbl values('" + txt_code.Text + "','" + txt_iname.Text + "','" + txt_price.Text + "','" + cmbItemCategory.SelectedValue.ToString() + "','" + txt_disc.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
            }
            
            txt_code.Text = "";
            txt_iname.Text = "";
            txt_price.Text = "";
            txt_disc.Text = "";
            cmbItemCategory.SelectedIndex = 0;
        }

        private void btn_iedit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update itemTbl set item_name = '" + txt_iname.Text + "', item_price = '" + txt_price.Text + "', item_category = '" + cmbItemCategory.SelectedValue.ToString() + "' , item_discount = '" + txt_disc.Text + "' where item_code = '" + txt_code.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_idelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                string myquery = "delete from itemTbl where item_code = '" + txt_code.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txt_code.Enabled = true;
            txt_code.Text = "";
            txt_iname.Text = "";
            txt_price.Text = "";
            txt_disc.Text = "";
            cmbItemCategory.SelectedIndex = 0;
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
                dgv_item.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_ihome_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
