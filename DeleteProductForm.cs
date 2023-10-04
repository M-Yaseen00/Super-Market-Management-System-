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
	public partial class DeleteProductForm : Form
	{
		public DeleteProductForm()
		{
			InitializeComponent();
		}
        private int tProduct_id;
        private void btnDelete_Click(object sender, EventArgs e)
		{
            ProductCollection pCol = new ProductCollection();

            if (pCol.DeleteProduct(tProduct_id) > 0)
            {
                MessageBox.Show("Are You Sure, You want to delete this Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Select Record Has been Deleted");
            }
            else
            {

                MessageBox.Show("Operation Fails!");

            }
            dgvProduct.DataSource = pCol.GetAllProducts();
            dgvProduct.Refresh();
            pCol = null;

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

            MainMenu manageproduct = new MainMenu();
            manageproduct.Show();
            this.Hide();
        }

		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            tProduct_id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[0].Value);

            StockCollection stockCol = new StockCollection();
            StockModel stock = stockCol.GetStock(tProduct_id);

            txtPID.Text = Convert.ToString(stock.stockId);
            txtPName.Text = stock.stockName;
            txtPPrice.Text = Convert.ToString(stock.stockQuantity);
            txtPDesc.Text = Convert.ToString(stock.stockCost);
        }

		private void DeleteProductForm_Load(object sender, EventArgs e)
		{
            ProductCollection pCol = new ProductCollection();
            dgvProduct.DataSource = pCol.GetAllProducts();
            dgvProduct.Refresh();
            pCol = null;
        }
	}
}
