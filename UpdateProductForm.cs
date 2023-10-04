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
	public partial class UpdateProductForm : Form
	{
		public UpdateProductForm()
		{
			InitializeComponent();
		}
        private int tProduct_id;
        private void btnUpdate_Click(object sender, EventArgs e)
		{

            ProductCollection pCol = new ProductCollection();

            ProductModel pMod = new ProductModel();

            pMod.PId = Convert.ToInt32(txtPID.Text);
            pMod.PName = txtPName.Text;
            pMod.PPrice = Convert.ToDouble(txtPPrice.Text);
            pMod.PDescription = txtPDesc.Text;

            int result = pCol.UpdateProduct(pMod);

            if (result > 0)
            {
                MessageBox.Show("Product Updated Successfully");
                dgvProduct.DataSource = pCol.GetAllProducts();
                dgvProduct.Refresh();

            }
            else
            {
                MessageBox.Show("Operation Fails!");

            }
            pMod = null;
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
            MainMenu updateproduct = new MainMenu();
            updateproduct.Show();
            this.Hide();
        }

		private void UpdateProductForm_Load(object sender, EventArgs e)
		{
            ProductCollection pCol = new ProductCollection();
            dgvProduct.DataSource = pCol.GetAllProducts();
            dgvProduct.Refresh();
            pCol = null;
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
	}
}
