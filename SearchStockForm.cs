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
	public partial class SearchStockForm : Form
	{
		public SearchStockForm()
		{
			InitializeComponent();
		}
        int tstockId;
        private void btnSearch_Click(object sender, EventArgs e)
		{
            if (cboSearchBy.SelectedValue.ToString() == "1")
            {
                StockCollection stockCol = new StockCollection();
                List<StockModel> searchStocks = stockCol.GetAllStocks();
                searchStocks = searchStocks.Where(x => Convert.ToString(x.stockId) == txtSearch.Text).ToList();
                dgvStock.DataSource = searchStocks;
                dgvStock.Refresh();
            }

            if (cboSearchBy.SelectedValue.ToString() == "2")
            {
                StockCollection stockCol = new StockCollection();
                List<StockModel> searchStocks = stockCol.GetAllStocks();
                searchStocks = searchStocks.Where(x => x.stockName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                dgvStock.DataSource = searchStocks;
                dgvStock.Refresh();
            }
        }

		private void btnback_Click(object sender, EventArgs e)
		{
            Manage_Stock searchstock = new Manage_Stock();
            searchstock.Show();
            this.Hide();
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

		private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            tstockId = Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[0].Value);

            StockCollection stockCol = new StockCollection();
            StockModel stock = stockCol.GetStock(tstockId);

            txtSId.Text = Convert.ToString(stock.stockId);
            txtSName.Text = stock.stockName;
            txtSQuantity.Text = Convert.ToString(stock.stockQuantity);
            txtSCost.Text = Convert.ToString(stock.stockCost);
            numericUpDown1.Text = Convert.ToString(stock.stockAlertQuantity);
        }

		private void SearchStockForm_Load(object sender, EventArgs e)
		{
            StockCollection stockCol = new StockCollection();
            dgvStock.DataSource = stockCol.GetAllStocks();
            dgvStock.Refresh();
            stockCol = null;

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
