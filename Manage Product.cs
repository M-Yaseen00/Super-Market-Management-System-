using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SuperMarket_Management_System_new_
{
	public partial class Manage_Product : Form
	{
		public Manage_Product()
		{
			InitializeComponent();
		}
		private void BtnBack_Click_1(object sender, EventArgs e)
		{
			MainMenu managestock = new MainMenu();
			managestock.Show();
			this.Hide();
		}

		private void BtnAddProduct_Click(object sender, EventArgs e)
		{
			AddProductForm addproductform = new AddProductForm();
			addproductform.Show();
			this.Hide();

		}

		private void BtnDeleteProduct_Click(object sender, EventArgs e)
		{
			DeleteProductForm deleteproductform = new DeleteProductForm();
			deleteproductform.Show();
			this.Hide();
		}

		private void BtnUpdateProduct_Click(object sender, EventArgs e)
		{
			UpdateProductForm updateproductform = new UpdateProductForm();
			updateproductform.Show();
			this.Hide();
		}

		private void BtnSearchProduct_Click(object sender, EventArgs e)
		{
			SearchProductForm searchproductform = new SearchProductForm();
			searchproductform.Show();
			this.Hide();
		}
		bool dropdown = true;
		private void menuStripDropDown_Click(object sender, EventArgs e)
		{
			if (dropdown == true)
			{
				menuStrip.Dock = DockStyle.Left;
				dropdown = false;
				menuStripDropDown.Text = "->";
			}
			else
			{
				menuStrip.Dock = DockStyle.Top;
				dropdown = true;
				menuStripDropDown.Text = "↓";

			}
		}
	}
}

