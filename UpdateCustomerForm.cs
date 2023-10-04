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
	public partial class UpdateCustomerForm : Form
	{
		public UpdateCustomerForm()
		{
			InitializeComponent();
		}
        private int tcust_id;
        private void UpdateCustomerForm_Load(object sender, EventArgs e)
		{
            CustomerCollection1 custCol = new CustomerCollection1();
            dgvCust.DataSource = custCol.GetAllCustomers();
            dgvCust.Refresh();
            custCol = null;
        }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            CustomerCollection1 custCol = new CustomerCollection1();

            CustomerModel cust = new CustomerModel();

            cust.Cust_Id = Convert.ToInt32(txtID.Text);
            cust.Cust_name = txtName.Text;
            cust.Cust_ph_no = txtPhoneNo.Text;
            cust.Cust_address = txtAddress.Text;
            cust.Cust_Email = txtEmail.Text;
            cust.Cust_CNIC = txtCNIC.Text;

            int result = custCol.UpdateCustomer(cust);

            if (result > 0)
            {
                MessageBox.Show("Customer Updated Successfully");
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
            FrmCustomer updatecustomer = new FrmCustomer();
            updatecustomer.Show();
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
	}
}
