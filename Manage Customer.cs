using SuperMarket_Management_System_new_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Management_System_new_
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

		private void BtnBack_Click(object sender, EventArgs e)
		{
            MainMenu managestock = new MainMenu();
            managestock.Show();
            this.Hide();
        }

		private void BtnAddCustomer_Click(object sender, EventArgs e)
		{
            AddCustomerForm addcustomerform = new AddCustomerForm();
            addcustomerform.Show();
            this.Hide();
        }

		private void BtnDeleteCustomer_Click(object sender, EventArgs e)
		{
            DeleteCustomerForm deletecustomerform = new DeleteCustomerForm();
            deletecustomerform.Show();
            this.Hide();

        }

		private void BtnUpdateCustomer_Click(object sender, EventArgs e)
		{
            UpdateCustomerForm updatecustomerform = new UpdateCustomerForm();
            updatecustomerform.Show();
            this.Hide();
        }

		private void BtnSearchCustomer_Click(object sender, EventArgs e)
		{
            SearchCustomerForm searchcustomerform = new SearchCustomerForm();
            searchcustomerform.Show();
            this.Hide();
        }
        bool dropdown = true;
        private void menuStripDropDown_Click(object sender, EventArgs e)
		{
            if (dropdown == true)
            {
                menuStrip.Dock = DockStyle.Left;
                dropdown = false;
                menuStripDropDown.Text = "->";
            }
            else
            {
                menuStrip.Dock = DockStyle.Top;
                dropdown = true;
                menuStripDropDown.Text = "↓";

            }
        }
	}
}
