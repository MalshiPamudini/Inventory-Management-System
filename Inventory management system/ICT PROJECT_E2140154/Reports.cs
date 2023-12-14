using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_PROJECT_E2140154
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        

        private void btnMonthlyRevenue_Click(object sender, EventArgs e)
        {
            DMReports dm = new DMReports();
            dm.Show();
            this.Hide();
        }

        private void btnMostDItem_Click(object sender, EventArgs e)
        {
            SalesDemanding sd = new SalesDemanding();
            sd.Show();
            this.Hide();
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            DMReports dm = new DMReports();
            dm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
