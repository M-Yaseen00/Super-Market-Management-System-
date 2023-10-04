using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Management_System_new_
{
    internal class BillController
    {
        private readonly string connetionString = "server=127.0.0.1;uid=root;password=Yaseen_26;database=supermarket_management_system";




        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> prodlist = new List<ProductModel>();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;
            //sql = "Select * from prod_tb";
            sql = "Select * from productinformation";
            
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ProductModel prod = new ProductModel();
                    prod.PId = Convert.ToInt32(dataReader.GetValue(0));
                    prod.PName = Convert.ToString(dataReader.GetValue(1));
                    prod.PPrice = Convert.ToDouble(dataReader.GetValue(2));
                    prod.PDescription = Convert.ToString(dataReader.GetValue(3));
                    prodlist.Add(prod);
                    prod = null;
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
            return prodlist;
        }
        public List<BillsModel> GetAllBills()
        {
            List<BillsModel> billslist = new List<BillsModel>();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;
            sql = "Select * from billtbl";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    BillsModel bill = new BillsModel();
                    bill.BillID = Convert.ToInt32(dataReader.GetValue(0));
                    bill.SellerName = Convert.ToString(dataReader.GetValue(1));
                    bill.datee = Convert.ToString(dataReader.GetValue(2));
                    bill.Amt = Convert.ToString(dataReader.GetValue(3));
                   
                    billslist.Add(bill);
                    bill = null;
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
            return billslist;
        }
        public int AddBill(BillsModel bill)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;


            sql = " insert into billtbl(BillID,SellerName,datee,Amt)" + " values('" + bill.BillID + "','" + bill.SellerName + "','" + bill.datee + "','" + bill.Amt + "')";
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
        public int DeleteBill(string id)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = " delete from billtbl where BillID=" + id;
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

    }
}
