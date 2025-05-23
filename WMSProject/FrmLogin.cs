using MySqlConnector;

namespace WMSProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public Database database;
        public MySqlConnection mySqlConnection;

        public static String user = "";

        private bool isValid()
        {
            bool result = true;
            string err = "";
            string username = txtUser.Text;
            string password = txtPass.Text;

            err += Validator.IsPresent(txtUser.Text, txtUser.Tag.ToString());
            err += Validator.IsPresent(txtPass.Text, txtPass.Tag.ToString());
            if (err != "")
            {
                result = false;
                MessageBox.Show(err, "Invalid Entry");
            }
            return result;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    string username = txtUser.Text;
                    string password = txtPass.Text;
                    //Check username and password
                    if ((username != "admin") && (password != "12345"))
                    {
                        txtUser.Clear();
                        txtPass.Clear();
                        MessageBox.Show("Incorrect Username/Password");
                    }
                    else
                    {
                        user = username;
                        var newForm = new FrmMain();
                        newForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Database database = Database.GetInstance();
            database.connectDB("localhost", "root", "root", "warehousedb", "3306");
            mySqlConnection = database.Connect();
            mySqlConnection.Open();
            if (mySqlConnection != null && mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show(" Connection successful!!!", "Database Connection", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(" Connection error!!!", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
