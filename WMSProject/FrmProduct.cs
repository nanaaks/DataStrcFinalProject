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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        List<Product> products = FrmInventory.products;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var newForm = new FrmInventory();
            newForm.Show();
            this.Close();
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            errorMessage += Validator.IsValidEmail(txtCategory.Text, txtCategory.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IProductBuilder productBuilder = new FoodProductBuilder();
            productBuilder.SetCode(Convert.ToInt32(txtCode.Text)).SetName(txtName.Text).SetCategory(txtCategory.Text).SetQuantity(Convert.ToInt32(txtQuantity.Text)).SetPrice(Convert.ToDouble(txtPrice.Text)).SetExpiry(Convert.ToDateTime(txtExpiry.Text));
            Product product = productBuilder.Build();
            products.Add(product);
        }
    }
}
