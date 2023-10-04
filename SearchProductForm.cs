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
	public partial class SearchProductForm : Form
	{
		public SearchProductForm()
		{
			InitializeComponent();
		}
		private int tProduct_id;
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (cboSearchBy.SelectedValue.ToString() == "1")
			{
				ProductCollection pCol = new ProductCollection();
				List<ProductModel> searchStocks = pCol.GetAllProducts();
				searchStocks = searchStocks.Where(x => Convert.ToString(x.PId) == txtSearch.Text).ToList();
				dgvProduct.DataSource = searchStocks;
				dgvProduct.Refresh();
			}

			if (cboSearchBy.SelectedValue.ToString() == "2")
			{
				ProductCollection prodCol = new ProductCollection();
				List<ProductModel> searchStocks = prodCol.GetAllProducts();
				searchStocks = searchStocks.Where(x => x.PName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
				dgvProduct.DataSource = searchStocks;
				dgvProduct.Refresh();
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

		private void btnback_Click(object sender, EventArgs e)
		{
			MainMenu updateproduct = new MainMenu();
            updateproduct.Show();
            this.Hide();
		}

		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ProductCollection prodCol = new ProductCollection();
			dgvProduct.DataSource = prodCol.GetAllProducts();
			dgvProduct.Refresh();
			prodCol = null;

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



			cboSearchBy.DataSource = searchDataList;
			cboSearchBy.DisplayMember = "Name";
			cboSearchBy.ValueMember = "ID";
			cboSearchBy.Refresh();
			searchDataList = null;
		}
	

		private void SearchProductForm_Load(object sender, EventArgs e)
		{
			ProductCollection prodCol = new ProductCollection();
			dgvProduct.DataSource = prodCol.GetAllProducts();
			dgvProduct.Refresh();
			prodCol = null;

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



			cboSearchBy.DataSource = searchDataList;
			cboSearchBy.DisplayMember = "Name";
			cboSearchBy.ValueMember = "ID";
			cboSearchBy.Refresh();
			searchDataList = null;
		}
	}
	
}
