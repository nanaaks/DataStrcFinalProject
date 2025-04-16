using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WMSProject
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        public Database database;
        public MySqlConnection mySqlConnection;

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            database = new Database("localhost", "root", "root", "warehousedb", "3306");
            mySqlConnection = database.Connect();
            mySqlConnection.Open();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new FrmMain();
            newForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newForm = new FrmProduct();
            newForm.Show();
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                String qStr = "SELECT * FROM inventory";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridAll.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
