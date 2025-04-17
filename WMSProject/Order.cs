using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WMSProject.FrmPending;

namespace WMSProject
{
    public class Order
    {
        private int orderNo;
        private DateTime orderDate;
        private string orderType;
        private string orderStatus;
        private int code;
        private string name;

        public Order(int orderNo, DateTime orderDate, string orderType, string orderStatus, int code, string name)
        {
            this.orderNo = orderNo;
            this.orderDate = orderDate;
            this.orderType = orderType;
            this.orderStatus = orderStatus;
            this.code = code;
            this.name = name;
        }

        public IOrderState State { get; set; }

        public Order(IOrderState initialState)
        {
            State = initialState;
        }

        /*
        public void Request()
        {
            State.Handle(this);
        }
        */

        public override string ToString()
        {
            return $"OrderNo: {orderNo}, OrderDate: {orderDate:yyyy-MM-dd}, OrderType: {orderType}, " +
                   $"OrderStatus: {orderStatus}, Code: {code}, Name: {name}";
        }

    }
}
