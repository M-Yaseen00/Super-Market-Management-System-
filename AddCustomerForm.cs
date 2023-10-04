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
	public partial class AddCustomerForm : Form
	{
		public AddCustomerForm()
		{
			InitializeComponent();
		}
        private int tcust_id;
        private void btnAdd_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please Enter ID");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneNo.Text))
            {
                MessageBox.Show("Please Enter Phone No");
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Email");
                return;
            }
            if (string.IsNullOrEmpty(txtCNIC.Text))
            {
                MessageBox.Show("Please Enter CNIC");
                return;
            }

            CustomerCollection1 custCol = new CustomerCollection1();

            CustomerModel cust = new CustomerModel();

            cust.Cust_Id = Convert.ToInt32(txtID.Text);
            cust.Cust_name = txtName.Text;
            cust.Cust_ph_no = txtPhoneNo.Text;
            cust.Cust_address = txtAddress.Text;
            cust.Cust_Email = txtEmail.Text;
            cust.Cust_CNIC = txtCNIC.Text;

            int result = custCol.AddCustomer(cust);

            if (result > 0)
            {
                MessageBox.Show("New Customer Added Successfully");
                dgvCust.DataSource = custCol.GetAllCustomers();
                dgvCust.Refresh();

            }
            else
            {
                MessageBox.Show("Operation Fails!");

            }

            cust = null;
            custCol = null;
        }

		private void btnclear_Click(object sender, EventArgs e)
		{
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

		private void btnback_Click(object sender, EventArgs e)
		{

            FrmCustomer addcustomer = new FrmCustomer();
            addcustomer.Show();
            this.Hide();

        }

		private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            tcust_id = Convert.ToInt32(dgvCust.Rows[e.RowIndex].Cells[0].Value);

            CustomerCollection1 custCol = new CustomerCollection1();
            CustomerModel cust = custCol.GetCustomer(tcust_id);

            txtID.Text = Convert.ToString(cust.Cust_Id);
            txtName.Text = cust.Cust_name;
            txtPhoneNo.Text = cust.Cust_ph_no;
            txtAddress.Text = cust.Cust_address;
            txtEmail.Text = cust.Cust_Email;
            txtCNIC.Text = cust.Cust_CNIC;
        }

		private void AddCustomerForm_Load(object sender, EventArgs e)
		{
            CustomerCollection1 custCol = new CustomerCollection1();
            dgvCust.DataSource = custCol.GetAllCustomers();
            dgvCust.Refresh();
            custCol = null;
        }
	}
}
