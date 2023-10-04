using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SuperMarket_Management_System_new_
{
	class CustomerCollection1
	{
        private readonly string connetionString = "server=127.0.0.1;uid=root;password=Yaseen_26;database=supermarket_management_system";
        //Add Customer
        public int AddCustomer(CustomerModel cust)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;


            sql = " insert into customer(Cust_Id,Cust_name,Cust_ph_no,Cust_address,Cust_Email,Cust_CNIC)Values(" + cust.Cust_Id + ",'" + cust.Cust_name + "','" + cust.Cust_ph_no + "','" + cust.Cust_address + "','" + cust.Cust_Email + "','" + cust.Cust_CNIC + "');";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                result = command.ExecuteNonQuery();
                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
            }
            finally
            {

                connection.Close();
            }
            return result;
        }
        //Update Customer

        public int UpdateCustomer(CustomerModel cust)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = "update customer set Cust_name='" + cust.Cust_name + "',Cust_ph_no=  '" + cust.Cust_ph_no + "' ,Cust_address ='" + cust.Cust_address + "',  Cust_Email = '" + cust.Cust_Email + "',Cust_CNIC ='" + cust.Cust_CNIC + "' where Cust_Id=" + Convert.ToString(cust.Cust_Id);
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                result = command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        //Delete Customer
        public int DeleteCustomer(int id)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = " delete from customer where Cust_Id=" + Convert.ToString(id);
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                result = command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = -1;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }



        //Get All Customer

        public List<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> custlist = new List<CustomerModel>();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;
            sql = "Select * from customer";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    CustomerModel cust = new CustomerModel();
                    cust.Cust_Id = Convert.ToInt32(dataReader.GetValue(0));
                    cust.Cust_name = Convert.ToString(dataReader.GetValue(1));
                    cust.Cust_ph_no = Convert.ToString(dataReader.GetValue(2));
                    cust.Cust_address = Convert.ToString(dataReader.GetValue(3));
                    cust.Cust_Email = Convert.ToString(dataReader.GetValue(4));
                    cust.Cust_CNIC = Convert.ToString(dataReader.GetValue(5));
                    custlist.Add(cust);
                    cust = null;
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                connection.Close();
            }
            return custlist;
        }


        //Get only one customer

        public CustomerModel GetCustomer(int id)
        {

            CustomerModel cust = new CustomerModel();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;


            sql = "Select * from customer where Cust_Id =" + id;
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {

                    cust.Cust_Id = Convert.ToInt32(dataReader.GetValue(0));
                    cust.Cust_name = Convert.ToString(dataReader.GetValue(1));
                    cust.Cust_ph_no = Convert.ToString(dataReader.GetValue(2));
                    cust.Cust_address = Convert.ToString(dataReader.GetValue(3));
                    cust.Cust_Email = Convert.ToString(dataReader.GetValue(4));
                    cust.Cust_CNIC = Convert.ToString(dataReader.GetValue(5));

                }
                dataReader.Close();
                command.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }
            return cust;
        }
    }
}

