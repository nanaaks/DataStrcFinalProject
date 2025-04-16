using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMSProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = FrmLogin.user;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var newForm = new FrmInventory();
            newForm.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var newForm = new FrmOrder();
            newForm.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var newForm = new FrmUser();
            newForm.Show();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var newForm = new FrmAccount();
            newForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var newForm = new FrmLogin();
            newForm.Show();
            this.Close();
        }
    }
}
