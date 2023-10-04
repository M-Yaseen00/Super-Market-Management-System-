using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SuperMarket_Management_System_new_
{
    public partial class Login : Form
    {
        private string connectionString = "server=127.0.0.1;uid=root;password=Yaseen_26;database=supermarket_management_system";

        public Login()
        {
            InitializeComponent();
        }

      
            private void btn_Login_Click(object sender, EventArgs e)
            {
                string userType = "";
                string username = txt_Username.Text;
                string password = txt_Password.Text;

                if (rbSeller.Checked)
                {
                    userType = "Seller";
                }
                else
                {
                    userType = "Admin";
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE UserType=@UserType AND Username=@Username AND Password=@Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserType", userType);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (rbSeller.Checked)
                    {
                        userType = "Seller";
                        Billing billing = new Billing();
                        billing.Show();
                        this.Hide();
                    }
                    else
                    {
                        userType = "Admin";
                        MainMenu mainMenu = new MainMenu(); 
                        mainMenu.Show();
                        this.Hide();
                    }

                }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn_Login_Click(sender, e);
                }
            }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }
    }
    }








