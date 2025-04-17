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
    public partial class FrmPending : Form
    {
        public FrmPending()
        {
            InitializeComponent();
        }

        private List<OrderContext> pendingOrders = new List<OrderContext>();

        private void FrmPending_Load(object sender, EventArgs e)
        {
            // Display all pending orders in listbox
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (pendingOrders.Count > 0)
            {
                var order = pendingOrders[0];
                order.State = new ApprovedState();
                order.Request();
                pendingOrders.Remove(order);
            }
            else
            {
                MessageBox.Show("No pending orders to approve.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pendingOrders.Count > 0)
            {
                var order = pendingOrders[0];
                order.State = new CanceledState();
                order.Request();
                pendingOrders.Remove(order);
            }
            else
            {
                MessageBox.Show("No pending orders to cancel.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new FrmOrder();
            newForm.Show();
            this.Close();
        }
    }
}
