using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WMSProject
{
    public partial class FrmOrder : Form
    {
        private List<OrderContext> pendingOrders = new List<OrderContext>();

        public FrmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // Optional: populate initial data or UI setup
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new FrmMain();
            newForm.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var order = new OrderContext(new PendingState());
            order.Request();
            pendingOrders.Add(order); // Add to approval list
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
    }

  
    public interface IOrderState
    {
        void Handle(OrderContext context);
    }

    public class OrderContext
    {
        public IOrderState State { get; set; }

        public OrderContext(IOrderState initialState)
        {
            State = initialState;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    public class PendingState : IOrderState
    {
        public void Handle(OrderContext context)
        {
            MessageBox.Show("Order is pending and added to approval list.");
        }
    }

    public class ApprovedState : IOrderState
    {
        public void Handle(OrderContext context)
        {
            // Replace this with DB insertion logic
            MessageBox.Show("Order approved and added to database.");
        }
    }

    public class CanceledState : IOrderState
    {
        public void Handle(OrderContext context)
        {
            MessageBox.Show("Order canceled and removed from approval list.");
        }
    }
}
