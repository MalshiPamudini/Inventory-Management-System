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
    public partial class DMReports : Form
    {
        public DMReports()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BubbleTeaShopDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DMReports_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM billingTbl";
            filterByDate(sql, dgvOrderManagement);
        }
        void filterByDate(string sql, DataGridView dtg)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt;
                cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = sql;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dtg.DataSource = dt;
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;


            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;

            sql = "select * from billingTbl where OderDate between '" + from.ToString("yyyy-MM-dd") + "' and '" + to.ToString("yyyy-MM-dd") + "'";
            filterByDate(sql, dgvOrderManagement);

            int sum = 0;
            for (int i = 0; i <= dgvOrderManagement.Rows.Count - 1; i++)
            {
                int TotalPrice = Convert.ToInt32(dgvOrderManagement.Rows[i].Cells[9].Value);
                sum = sum + TotalPrice;
            }
            lblRevenue.Text = "Rs. " + sum.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM billingTbl";
            filterByDate(sql, dgvOrderManagement);

            lblRevenue.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
