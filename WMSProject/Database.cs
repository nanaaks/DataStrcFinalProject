using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel;

namespace WMSProject
{
    public class Database
    {
        private static Database instance;
        private String ServerAddress { get; set; }
        private String UserName { get; set; }
        private String Password { get; set; }
        private String DatabaseName { get; set; }
        private String PortNumber { get; set; }

        private Database() 
        {
            ServerAddress = this.ServerAddress;
            UserName = this.UserName;
            Password = this.Password;
            DatabaseName = this.DatabaseName;
            PortNumber = this.PortNumber;

        }

        public static Database GetInstance()
        {
            if (instance == null)
            {
                if (instance == null)
                {
                    instance = new Database();
                }
            }
            return instance;
        }

        public void connectDB(string serverAddress, string userName, string password, string databaseName, string portNumber)
        {
            ServerAddress = serverAddress;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            PortNumber = portNumber;
        }

        public MySqlConnection Connect()
        {
            String connStr = $"Server= {this.ServerAddress}; port={this.PortNumber}; User id = {this.UserName}; Password = {this.Password} ; Database = {this.DatabaseName}";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Connecting to database" + ex.Message);
                return null;
            }
        }
    }
}
