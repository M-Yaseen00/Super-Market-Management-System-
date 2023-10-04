using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SuperMarket_Management_System_new_
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private string _username;

		public MainMenu(string username)
		{
			InitializeComponent();
			_username = username;

			// Show/hide controls based on user role
			if (IsAdmin())
			{
				lblWelcome.Text = "Welcome, Admin!";
				// Add controls for admin functionality here
			}
			else
			{
				lblWelcome.Text = "Welcome, Employee!";
				// Add controls for employee functionality here
			}
		}
		private bool IsAdmin()
		{
			// Check if user is admin or employee
			string connectionString = "your_connection_string_here";
			string query = "SELECT Role FROM Users WHERE Username = @Username";
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Username", _username);
					string role = command.ExecuteScalar().ToString();
					return role == "admin";
				}
			}
		}

		bool dropdown = true;
		private void menustripdropdown_Click(object sender, EventArgs e)
		{
			if (dropdown == true)
			{
				menuStrip.Dock = DockStyle.Left;
				//menuStrip.AutoSize = false;
				//menuStrip.Size = new Size(90, 30);
				dropdown = false;
				menustripdropdown.Text = "->";
			}
			else
			{
				menuStrip.Dock = DockStyle.Top;
				dropdown = true;
				menustripdropdown.Text = "↓";

			}
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			Manage_Product productform = new Manage_Product();
			productform.Show();
			this.Hide();
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			FrmCustomer customerform = new FrmCustomer();
			customerform.Show();
			this.Hide();
		}

		private void btnStock_Click(object sender, EventArgs e)
		{
			Manage_Stock stockform = new Manage_Stock();
			stockform.Show();
			this.Hide();
		}

		private void btnBilling_Click(object sender, EventArgs e)
		{
			Billing billingform = new Billing();
			billingform.Show();
			this.Hide();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Login loginForm = new Login();
			this.Hide();
			loginForm.ShowDialog();
			this.Close();
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
	}
}
