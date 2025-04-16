namespace WMSProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static String user = "";
        List<String> users = new List<String>();

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
    }
}
