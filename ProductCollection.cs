using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SuperMarket_Management_System_new_
{
	internal class ProductCollection
	{
        public readonly string connetionString = "server=127.0.0.1;uid=root;password=Yaseen_26;database=supermarket_management_system";

        //Add Product
        public int AddProduct(ProductModel pMod)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string query = null;

            query = " insert into productinformation(productId,productName,productPrice,productDescription)Values(" + pMod.PId + ",'" + pMod.PName + "','" + pMod.PPrice + "','" + pMod.PDescription + "')";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
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

        //Update Product

        public int UpdateProduct(ProductModel pMod)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            sql = sql = "update productinformation set productName='" + pMod.PName + "',productPrice=  '" + pMod.PPrice + "' ,productDescription ='" + pMod.PDescription + "' where productId=" + Convert.ToString(pMod.PId);
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
        //Delete Product
        public int DeleteProduct(int id)
        {

            int result = -1;
            MySqlConnection connection;
            MySqlCommand command;
            string query = null;
            query = " delete from productinformation where productId=" + Convert.ToString(id);
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
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

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> prolist = new List<ProductModel>();
            MySqlConnection connection;
            MySqlCommand command;
            string sql = null;
            MySqlDataReader dataReader;
            sql = "Select * from productinformation";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ProductModel pmod = new ProductModel();
                    pmod.PId = Convert.ToInt32(dataReader.GetValue(0));
                    pmod.PName = Convert.ToString(dataReader.GetValue(1));
                    pmod.PPrice = Convert.ToDouble(dataReader.GetValue(2));
                    pmod.PDescription = Convert.ToString(dataReader.GetValue(3));
                    prolist.Add(pmod);
                    pmod = null;
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
            return prolist;
        }

    }
}
