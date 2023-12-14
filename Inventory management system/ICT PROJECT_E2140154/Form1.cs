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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from staffregTbl where EuserName='" + txtUname.Text + "' and Epassword ='" + txtPassword.Text + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[1].ToString() == "admin")
                {
                    Ulogs.type = "a";
                }
                else if (dr[1].ToString() == "cashier")
                {
                    Ulogs.type = "c";
                }

                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            if (cbShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {

            txtUname.Text = "";
            txtPassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
