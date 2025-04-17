using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace WMSProject
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        public Database database;
        public MySqlConnection mySqlConnection;

        public static List<Order> orders = new List<Order>();

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            //Connect database
            Database database = Database.GetInstance();
            database.connectDB("localhost", "root", "root", "warehousedb", "3306");
            mySqlConnection = database.Connect();
            mySqlConnection.Open();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new FrmMain();
            newForm.Show();
            this.Close();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            var newForm = new FrmPending();
            newForm.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                String qStr = "SELECT * FROM orders";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataOrders.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
