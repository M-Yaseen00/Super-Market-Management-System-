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
	public partial class DeleteStockForm : Form
	{
		public DeleteStockForm()
		{
			InitializeComponent();
		}
        int tstockId;
        private void btnDelete_Click(object sender, EventArgs e)
		{
            StockCollection stockCol = new StockCollection();

            if (stockCol.DeleteStock(tstockId) > 0)
            {
                MessageBox.Show("Are You Sure, You Want to delete this Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Select Record Has been Deleted");
            }
            else
            {

                MessageBox.Show("Operation Fails!");

            }
            dgvStock.DataSource = stockCol.GetAllStocks();
            dgvStock.Refresh();
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
            Manage_Stock deletestock = new Manage_Stock();
            deletestock.Show();
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

		private void DeleteStockForm_Load(object sender, EventArgs e)
		{
            StockCollection stockCol = new StockCollection();
            dgvStock.DataSource = stockCol.GetAllStocks();
            dgvStock.Refresh();
            stockCol = null;
        }
	}
}
