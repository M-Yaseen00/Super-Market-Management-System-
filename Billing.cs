using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
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
using System.Xml.Linq;

namespace SuperMarket_Management_System_new_
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            // string value = form1.username;
            //SellerNamelbl.Text = value;
        }


       

    BillController billController= new BillController();
		
        int Grdtotal = 0,n=1;
        private void button1_Click(object sender, EventArgs e)
        {
          

            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            
            else
            {
                int total = Convert.ToInt32(Convert.ToDouble(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text));


                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
               
                newRow.Cells[0].Value = n++;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = total;
                ORDERDGV.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "Rs " + Grdtotal;
            }
        }

        

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();

            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Form1 seller = new Form1();
            // SellerNamelbl.Text=seller.Busername;
            // SellerNamelbl.Text = form1.username;
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() ;
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(BillID.Text))
            {
                MessageBox.Show("Please Enter Bill_ID");
                return;
            }
           

            BillController billCol = new BillController();

            BillsModel bill = new BillsModel();

            bill.BillID = Convert.ToInt32(BillID.Text);
            bill.SellerName = SellerNamelbl.Text;
            bill.datee = Datelbl.Text;
            bill.Amt = Amtlbl.Text;
           

            int result = billCol.AddBill(bill);

            if (result > 0)
            {
                MessageBox.Show("Bill Added Successfully");
                BillsDGV.DataSource = billCol.GetAllBills();
                BillsDGV.Refresh();

            }
            else
            {
                MessageBox.Show("Operation Fails!");

            }

            bill = null;
            billCol = null;

        }
       

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            BillController billCol = new BillController();
            BillsDGV.DataSource = billCol.GetAllBills();
            BillsDGV.Refresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILYSUPERMARKET", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));

            e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("FAMILYSUPERMARKET", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270, 230));

        }
        //Get Products
        private void button8_Click(object sender, EventArgs e)
        {
            BillController billCol = new BillController();
            ProdDGV.DataSource = billCol.GetAllProducts();
            ProdDGV.Refresh();
            billCol = null;
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {

            BillController custCol = new BillController();

            if (custCol.DeleteBill(id) > 0)
            {
                MessageBox.Show("Select Record Has been Deleted");
            }
            else
            {

                MessageBox.Show("Operation Fails!");

            }
            BillsDGV.DataSource = custCol.GetAllBills();
            BillsDGV.Refresh();
            custCol = null;
        }
        String id ;
        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = BillsDGV.SelectedRows[0].Cells[0].Value.ToString();
        }

		private void btnBack_Click(object sender, EventArgs e)
		{
            MainMenu managebilling = new MainMenu();
            managebilling.Show();
            this.Hide();
        }

		private void btnexit_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
