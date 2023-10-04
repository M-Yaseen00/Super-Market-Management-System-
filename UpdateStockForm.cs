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
	public partial class UpdateStockForm : Form
	{
		public UpdateStockForm()
		{
			InitializeComponent();
		}
        int tstockId;
        private void btnUpdate_Click(object sender, EventArgs e)
		{
            StockCollection stockCol = new StockCollection();

            StockModel stock = new StockModel();

            stock.stockId = Convert.ToInt32(txtSId.Text);
            stock.stockName = txtSName.Text;
            stock.stockQuantity = Convert.ToInt32(txtSQuantity.Text);
            stock.stockCost = Convert.ToInt32(txtSCost.Text);
            stock.stockAlertQuantity = Convert.ToInt32(numericUpDown1.Text);

            int result = stockCol.UpdateStock(stock);

            if (result > 0)
            {
                MessageBox.Show("Stock  Updated Successfully");
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
            Manage_Stock updatestock = new Manage_Stock();
            updatestock.Show();
            this.Hide();
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

		private void UpdateStockForm_Load(object sender, EventArgs e)
		{
            StockCollection stockCol = new StockCollection();
            dgvStock.DataSource = stockCol.GetAllStocks();
            dgvStock.Refresh();
            stockCol = null;
        }
	}
}
