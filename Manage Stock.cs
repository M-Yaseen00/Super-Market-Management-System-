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
	public partial class Manage_Stock : Form
	{
		public Manage_Stock()
		{
			InitializeComponent();
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

		private void BtnAddStock_Click(object sender, EventArgs e)
		{
			AddStockForm addstockform = new AddStockForm();
			addstockform.Show();
			this.Hide();
		}

		private void BtnDeleteStock_Click(object sender, EventArgs e)
		{
			DeleteStockForm deletestockform = new DeleteStockForm();
			deletestockform.Show();
			this.Hide();
		}

		private void BtnUpdateStock_Click(object sender, EventArgs e)
		{
			UpdateStockForm updatestockform = new UpdateStockForm();
			updatestockform.Show();
			this.Hide();
		}

		private void BtnSearchStock_Click(object sender, EventArgs e)
		{
			SearchStockForm searchstockform = new SearchStockForm();
			searchstockform.Show();
			this.Hide();
		}

		private void BtnBack_Click_1(object sender, EventArgs e)
		{
			MainMenu managestock = new MainMenu();
			managestock.Show();
			this.Hide();
		}
	}
}
