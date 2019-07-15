//Name: A.J. Richardson
//Date: 5/8/17
//Description: This program takes information from an access database and puts in
//the form to be viewed.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FinalAJ1552
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Missclick
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //connection to database
        OleDbConnection Connection = new OleDbConnection();

        //open database connection
        public void openDatabase()
        {
            try
            {
                string conn = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=CustomerInfo.accdb;" +
                    "Persist Security Info=False;";
                Connection.ConnectionString = conn;
                Connection.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Database could not open because: " + error.Message,
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //fill the combobox with the customer numbers
        public void fillCombobox()
        {
            try
            {
                string sql = "select distinct IDnumber from PersonalInfo order by IDnumber";

                OleDbDataAdapter customerNum = new OleDbDataAdapter(sql, Connection);
                customerNum.Fill(customerNumberDS, "IDnumber");

                customerCB.DataSource = customerNumberDS.Tables[0];
                customerCB.DisplayMember = "IDnumber";
                customerCB.ValueMember = "IDnumber";
            }
            catch (Exception error)
            {
                MessageBox.Show("Trouble pulling up customer numbers from database because: "
                    + error.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //When this program runs, the following methods will start. 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                openDatabase();
                fillCombobox();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error in load form event handler: " +
                    error.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //All inside work of retrieving data from database and putting it in required areas
        private void customerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string currentCustomer = customerCB.Text;
                if (currentCustomer != "System.Data.DataRowView")
                {
                    customerDS.Clear();
                    detailsDS.Clear();

                    string sql = "SELECT PersonalInfo.FirstName, " +
                        "PersonalInfo.LastName, PersonalInfo.PhoneNumber," +
                    "PersonalInfo.EmailAddress, PersonalInfo.Address, ZipCode.City," +
                        "ZipCode.State, ZipCode.Zip FROM " +
                    "(ZipCode INNER JOIN PersonalInfo ON ZipCode.[Zip] = " +
                    "PersonalInfo.[Zip]) " +
                    "where PersonalInfo.IDnumber = " + currentCustomer;

                    OleDbDataAdapter dsCustomer = new OleDbDataAdapter(sql, Connection);
                    dsCustomer.Fill(customerDS, "customer");
                    DataRow currentData = customerDS.Tables["customer"].Rows[0];

                    firstTB.Text = currentData[0].ToString();
                    lastTB.Text = currentData[1].ToString();
                    phoneTB.Text = currentData[2].ToString();
                    string x = phoneTB.Text;
                    double y = Double.Parse(x);
                    phoneTB.Text = String.Format("{0:(###)-###-####}", y);
                    emailTB.Text = currentData[3].ToString();
                    addressTB.Text = currentData[4].ToString();
                    cityTB.Text = currentData[5].ToString();
                    stateTB.Text = currentData[6].ToString();
                    zipTB.Text = currentData[7].ToString();

                    string sql2 = "SELECT OrderInfo.OrderNumber, " +
                        "OrderInfo.OrderDate, OrderInfo.[OrderShipped], " +
                        "OrderInfo.ShippingFee FROM OrderInfo " +
                        "where OrderInfo.IDnumber = " + currentCustomer +
                        " order by OrderInfo.OrderNumber";


                    OleDbDataAdapter dsDetails = new OleDbDataAdapter(sql2, Connection);
                    dsDetails.Fill(detailsDS, "OrderNumber");
                    customerDataDGV.Rows.Clear();
                    double sum = 0;
                    foreach (DataRow items in detailsDS.Tables[0].Rows)
                    {
                        double shippingFee = Convert.ToDouble(items[3]);
                        customerDataDGV.Rows.Add(items[0].ToString(), items[1].ToString(),
                            items[2].ToString(), shippingFee.ToString("C"));

                        sum += shippingFee;
                        shipTB.Text = sum.ToString("C");

                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error in combo box index change event handler: " +
                    error.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
