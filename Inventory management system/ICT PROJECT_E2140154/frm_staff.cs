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
    public partial class frm_staff : Form
    {
        public frm_staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Eid.Text == "")
            {
                MessageBox.Show("Enter the Employee ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {

               
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into staffregTbl values('" + txt_Eid.Text + "','" + txt_Euser.Text + "','" + txt_Ename.Text + "','" + txt_Epassword.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();
            }
            txt_Eid.Text = "";
            txt_Euser.Text = "";
            txt_Ename.Text = "";
            txt_Epassword.Text = "";

        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from staffregTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv_Staffreg.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void frm_staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update staffregTbl set Eid ='" + txt_Eid.Text + "', EuserName = '" + txt_Euser.Text + "',EfullName = '" + txt_Ename.Text + "' where Epassword= '" + txt_Epassword.Text + "' ", Con);
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

        private void dgv_Staffreg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Eid.Text = dgv_Staffreg.SelectedRows[0].Cells[0].Value.ToString();
            txt_Euser.Text = dgv_Staffreg.SelectedRows[0].Cells[1].Value.ToString();
            txt_Ename.Text = dgv_Staffreg.SelectedRows[0].Cells[2].Value.ToString();
            txt_Epassword.Text = dgv_Staffreg.SelectedRows[0].Cells[3].Value.ToString();
            txt_Eid.Enabled = false;
        }

        private void dgv_Staffreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Eid.Text = dgv_Staffreg.SelectedRows[0].Cells[0].Value.ToString();
            txt_Euser.Text = dgv_Staffreg.SelectedRows[0].Cells[1].Value.ToString();
            txt_Ename.Text = dgv_Staffreg.SelectedRows[0].Cells[2].Value.ToString();
            txt_Epassword.Text = dgv_Staffreg.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                string myquery = "delete from staffregTbl where Eid = '" + txt_Eid.Text + "'";
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
            
                txt_Eid.Text = "";
                txt_Euser.Text = "";
                txt_Ename.Text = "";
                txt_Epassword.Text = "";
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void btn_Inew_Click(object sender, EventArgs e)
        {
            txt_Eid.Enabled = true;
            txt_Eid.Text = "";
            txt_Ename.Text = "";
            txt_Epassword.Text = "";
            txt_Euser.Text = "";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
