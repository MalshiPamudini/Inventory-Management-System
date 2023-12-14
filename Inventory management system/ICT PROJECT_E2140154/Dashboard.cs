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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pbStaffReg_Click(object sender, EventArgs e)
        {
            frm_staff fg = new frm_staff();
            fg.Show();
            this.Hide();
        }

        private void lblStaffReg_Click(object sender, EventArgs e)
        {
            frm_staff fg = new frm_staff();
            fg.Show();
            this.Hide();
        }

        private void pbIManagement_Click(object sender, EventArgs e)
        {
            frm_Item itemManagement = new frm_Item();
            itemManagement.Show();
            this.Hide();
        }

        private void lblIManagement_Click(object sender, EventArgs e)
        {
            frm_Item itemManagement = new frm_Item();
            itemManagement.Show();
            this.Hide();
        }

        private void pbCatManagement_Click(object sender, EventArgs e)
        {
            catagory category = new catagory();
            category.Show();
            this.Hide();
        }

        private void lblCatManagement_Click(object sender, EventArgs e)
        {
            catagory category = new catagory();
            category.Show();
            this.Hide();
        }

        private void pbReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void pbbill_Click(object sender, EventArgs e)
        {
            bill bill = new bill();
            bill.Show();
            this.Hide();
        }

        private void lblbill_Click(object sender, EventArgs e)
        {
            bill bill = new bill();
            bill.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Ulogs.type == "a")
            {
                lblStaffReg.Enabled = true;
                pbStaffReg.Enabled = true;
                lblCatManagement.Enabled = true;
                pbCatManagement.Enabled = true;
                lblIManagement.Enabled = true;
                pbIManagement.Enabled = true;
                lblReports.Enabled = true;
                pbReports.Enabled = true;
                lblbill.Enabled = false;
                pbbill.Enabled = false;
            }
            else if (Ulogs.type == "c")
            {
                lblStaffReg.Enabled = false;
                pbStaffReg.Enabled = false;
                lblCatManagement.Enabled = false;
                pbCatManagement.Enabled = false;
                lblIManagement.Enabled = false;
                pbIManagement.Enabled = false;
                lblReports.Enabled = false;
                pbReports.Enabled = false;
                lblbill.Enabled = true;
                pbbill.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
