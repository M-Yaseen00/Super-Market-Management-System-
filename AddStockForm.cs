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
	public partial class AddStockForm : Form
	{
		public AddStockForm()
		{
			InitializeComponent();
		}

		private void btnback_Click(object sender, EventArgs e)
		{
			Manage_Stock addstock = new Manage_Stock();
			addstock.Show();
			this.Hide();
		}
        int tstockId;
        private void btnAddStock_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtSId.Text))
            {
                MessageBox.Show("Please Enter ID");
                return;
            }
            if (string.IsNullOrEmpty(txtSName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(txtSQuantity.Text))
            {
                MessageBox.Show("Please Enter Quantity");
                return;
            }
            if (string.IsNullOrEmpty(txtSCost.Text))
            {
                MessageBox.Show("Please Enter Cost");
                return;
            }
            if (string.IsNullOrEmpty(numericUpDown1.Text))
            {
                MessageBox.Show("Please Enter Alert Quantity");
                return;
            }
            StockCollection stockCol = new StockCollection();

            StockModel stock = new StockModel();

            stock.stockId = Convert.ToInt32(txtSId.Text);
            stock.stockName = txtSName.Text;
            stock.stockQuantity = Convert.ToInt32(txtSQuantity.Text);
            stock.stockCost = Convert.ToInt32(txtSCost.Text);
            stock.stockAlertQuantity = Convert.ToInt32(numericUpDown1.Text);

            int result = stockCol.AddStock(stock);

            if (result > 0)
            {
                MessageBox.Show("New Stock Added Successfully");
                dgvStock.DataSource = stockCol.GetAllStocks();
                dgvStock.Refresh();

            }
            else
            {
                MessageBox.Show("Operation Fails!");

            }

            stock = null;
            stockCol = null;
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

		private void AddStockForm_Load(object sender, EventArgs e)
		{

            StockCollection stockCol = new StockCollection();
            dgvStock.DataSource = stockCol.GetAllStocks();
            dgvStock.Refresh();
            stockCol = null;
        }

		private void btnClear_Click(object sender, EventArgs e)
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
