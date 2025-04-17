using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;

namespace WMSProject
{
    public partial class FrmInventory : Form
    {
        public static List<Product> products = new List<Product>();

        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            updateList();
        }

        public void updateList()
        {
            // Clear listbox (prevent repeating items)  and then redisplay all the items

            listBox1.Items.Clear();
            foreach (Product product in products)
            {
                listBox1.Items.Add(product);
            }
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
            updateList();
        }
    }
}
