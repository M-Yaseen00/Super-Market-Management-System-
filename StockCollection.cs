using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SuperMarket_Management_System_new_
{
	class StockCollection 
	{
        private readonly string connetionString = "server=127.0.0.1;uid=root;password=Yaseen_26;database=supermarket_management_system";

        public int AddStock(StockModel stock)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;


            sql = " insert into stockmanagement(stockId,stockName,stockQuantity,stockCost,stockAlertQuantity)Values(" + stock.stockId + ",'" + stock.stockName + "','" + stock.stockQuantity + "','" + stock.stockCost + "','" + stock.stockAlertQuantity + "');";
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


        public int UpdateStock(StockModel stock)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = sql = "update stockmanagement set stockName='" + stock.stockName + "',stockQuantity=  '" + stock.stockQuantity + "' ,stockCost ='" + stock.stockCost + "',  stockAlertQuantity = '" + stock.stockAlertQuantity + "' where stockId=" + Convert.ToString(stock.stockId);
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


        public int DeleteStock(int id)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = " delete from stockmanagement where stockId=" + Convert.ToString(id);
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



        // Get All Stock

        public List<StockModel> GetAllStocks()
        {
            List<StockModel> stocklist = new List<StockModel>();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;
            sql = "Select * from stockmanagement";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    StockModel stock = new StockModel();
                    stock.stockId = Convert.ToInt32(dataReader.GetValue(0));
                    stock.stockName = Convert.ToString(dataReader.GetValue(1));
                    stock.stockQuantity = Convert.ToInt32(dataReader.GetValue(2));
                    stock.stockCost = Convert.ToInt32(dataReader.GetValue(3));
                    stock.stockAlertQuantity = Convert.ToInt32(dataReader.GetValue(4));
                    stocklist.Add(stock);
                    stock = null;
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
            return stocklist;
        }


        //Get only one Stock

        public StockModel GetStock(int id)
        {

            StockModel stock = new StockModel();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;

            sql = "Select * from stockmanagement where stockId =" + id;
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {

                    stock.stockId = Convert.ToInt32(dataReader.GetValue(0));
                    stock.stockName = Convert.ToString(dataReader.GetValue(1));
                    stock.stockQuantity = Convert.ToInt32(dataReader.GetValue(2));
                    stock.stockCost = Convert.ToInt32(dataReader.GetValue(3));
                    stock.stockAlertQuantity = Convert.ToInt32(dataReader.GetValue(4));

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
            return stock;
        }

    }
}
