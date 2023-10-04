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
	public partial class AddProductForm : Form
	{
		public AddProductForm()
		{
			InitializeComponent();
		}
        private int tProduct_id;

        private void btnAdd_Click(object sender, EventArgs e)
		{
            ProductCollection pCol = new ProductCollection();

            ProductModel pMod = new ProductModel();

            if (string.IsNullOrEmpty(txtPID.Text))
            {
                MessageBox.Show("Please Enter ID");
                return;
            }
            if (string.IsNullOrEmpty(txtPName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(txtPPrice.Text))
            {
                MessageBox.Show("Please Enter Phone No");
                return;
            }
            if (string.IsNullOrEmpty(txtPDesc.Text))
            {
                MessageBox.Show("Please Enter Address");
                return;
            }

            pMod.PId = Convert.ToInt32(txtPID.Text);
            pMod.PName = txtPName.Text;
            pMod.PPrice = Convert.ToDouble(txtPPrice.Text);
            pMod.PDescription = txtPDesc.Text;

            int result = pCol.AddProduct(pMod);

            if (result > 0)
            {
                MessageBox.Show("New Product Added Successfully");
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

		private void AddProductForm_Load(object sender, EventArgs e)
		{
            ProductCollection pCol = new ProductCollection();
            dgvProduct.DataSource = pCol.GetAllProducts();
            dgvProduct.Refresh();
            pCol = null;
        }
	}
}
