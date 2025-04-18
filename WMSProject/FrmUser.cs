﻿using System;
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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        public Database database;
        public MySqlConnection mySqlConnection;

        private void FrmUser_Load(object sender, EventArgs e)
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                String qStr = "SELECT * FROM users";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataUsers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
