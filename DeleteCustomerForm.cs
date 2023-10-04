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
	public partial class DeleteCustomerForm : Form
	{
		public DeleteCustomerForm()
		{
			InitializeComponent();
		}
        private int tcust_id;
        private void btnDelete_Click(object sender, EventArgs e)
		{
            CustomerCollection1 custCol = new CustomerCollection1();

            if (custCol.DeleteCustomer(tcust_id) > 0)
            {
                MessageBox.Show("Are You Sure, You want to delete this customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Select Record Has been Deleted");
            }
            else
            {

                MessageBox.Show("Operation Fails!");

            }
            dgvCust.DataSource = custCol.GetAllCustomers();
            dgvCust.Refresh();
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
            FrmCustomer deletecustomer = new FrmCustomer();
            deletecustomer.Show();
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

		private void DeleteCustomerForm_Load(object sender, EventArgs e)
		{
            CustomerCollection1 custCol = new CustomerCollection1();
            dgvCust.DataSource = custCol.GetAllCustomers();
            dgvCust.Refresh();
            custCol = null;
        }
	}
}
