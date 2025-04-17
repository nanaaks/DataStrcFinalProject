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

        //List<Order> orders = FrmOrder.orders;
        List<Order> orders = FrmOrder.orders;
        Order order1 = new Order(1001, new DateTime(2025, 4, 17), "Online", "Pending", 200, "Alice");
        Order order2 = new Order(1002, new DateTime(2025, 4, 15), "In-Store", "Shipped", 201, "Bob");
        Order order3 = new Order(1003, new DateTime(2025, 4, 10), "Phone", "Delivered", 202, "Charlie");


        private List<OrderContext> pendingOrders = new List<OrderContext>();

        private void FrmPending_Load(object sender, EventArgs e)
        {
            // Display all pending orders in listbox
            orders.Add(order1);
            orders.Add(order2); 
            orders.Add(order3);
            updateList();
        }

        public void updateList()
        {
            // Clear listbox (prevent repeating items)  and then redisplay all the items

            lboxPending.Items.Clear();
            foreach (Order order in orders)
            {
                lboxPending.Items.Add(order);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var order = new OrderContext(new PendingState());
            order.Request();
            pendingOrders.Add(order); // Add to approval list
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var newForm = new FrmOrder();
            newForm.Show();
            this.Close();
        }
    }
}
