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
	public partial class SearchCustomerForm : Form
	{
		public SearchCustomerForm()
		{
			InitializeComponent();
		}
		private int tcust_id;

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

		private void SearchCustomerForm_Load(object sender, EventArgs e)
		{
			CustomerCollection1 custCol = new CustomerCollection1();
			dgvCust.DataSource = custCol.GetAllCustomers();
			dgvCust.Refresh();
			custCol = null;

			List<SearchLookUpData> searchDataList = new List<SearchLookUpData>();
			SearchLookUpData searchData = new SearchLookUpData();
			searchData.ID = 1;
			searchData.Name = "Search By ID";
			searchDataList.Add(searchData);
			searchData = null;
			searchData = new SearchLookUpData();
			searchData.ID = 2;
			searchData.Name = "Search By Name";
			searchDataList.Add(searchData);
			searchData = new SearchLookUpData();
			searchData.ID = 3;
			searchData.Name = "Search By CNIC";
			searchDataList.Add(searchData);


			cboSearchBy.DataSource = searchDataList;
			cboSearchBy.DisplayMember = "Name";
			cboSearchBy.ValueMember = "ID";
			cboSearchBy.Refresh();
			searchDataList = null;
		}

		private void btnback_Click(object sender, EventArgs e)
		{
			FrmCustomer searchcustomer = new FrmCustomer();
			searchcustomer.Show();
			this.Hide();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (cboSearchBy.SelectedValue.ToString() == "1")
			{
				CustomerCollection1 CustCol = new CustomerCollection1();
				List<CustomerModel> searchCusts = CustCol.GetAllCustomers();
				searchCusts = searchCusts.Where(x => Convert.ToString(x.Cust_Id) == txtSearch.Text).ToList();
				dgvCust.DataSource = searchCusts;
				dgvCust.Refresh();
			}

			if (cboSearchBy.SelectedValue.ToString() == "2")
			{
				CustomerCollection1 CustCol = new CustomerCollection1();
				List<CustomerModel> searchCusts = CustCol.GetAllCustomers();
				searchCusts = searchCusts.Where(x => x.Cust_name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
				dgvCust.DataSource = searchCusts;
				dgvCust.Refresh();
			}

			if (cboSearchBy.SelectedValue.ToString() == "3")
			{
				CustomerCollection1 CustCol = new CustomerCollection1();
				List<CustomerModel> searchCusts = CustCol.GetAllCustomers();
				searchCusts = searchCusts.Where(x => x.Cust_CNIC.Contains(txtSearch.Text)).ToList();
				dgvCust.DataSource = searchCusts;
				dgvCust.Refresh();
			}
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
	}
}
