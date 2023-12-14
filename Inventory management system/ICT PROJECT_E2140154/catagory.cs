using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ICT_PROJECT_E2140154
{
    public partial class catagory : Form
    {
        public catagory()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void dgv_cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ccode.Text = dgv_cat.SelectedRows[0].Cells[0].Value.ToString();
            txt_Cname.Text = dgv_cat.SelectedRows[0].Cells[1].Value.ToString();
            txt_Ccode.Enabled = false;
        }

        private void dgv_cat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ccode.Text = dgv_cat.SelectedRows[0].Cells[0].Value.ToString();
            txt_Cname.Text = dgv_cat.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void catagory_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CatTbl ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_cat.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void btn_Cnew_Click(object sender, EventArgs e)
        {
            txt_Ccode.Enabled = true;
            txt_Ccode.Text = "";
            txt_Cname.Text = "";
        }

        private void btn_Cadd_Click(object sender, EventArgs e)
        {
            if (txt_Ccode.Text == "")
            {
                MessageBox.Show("Enter the Category ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CatTbl values('" + txt_Ccode.Text + "','" + txt_Cname.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
            }
            
            txt_Ccode.Text = "";
            txt_Cname.Text = "";
        }

        private void btn_Cedit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CatTbl set Cat_name ='" + txt_Cname.Text + "' where Cat_code= '" + txt_Ccode.Text + "' ", Con);
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

        private void btn_Chome_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void btn_Cdele_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                string myquery = "delete from CatTbl where Cat_code = '" + txt_Ccode.Text + "'";
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
            txt_Ccode.Text = "";
            txt_Cname.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
