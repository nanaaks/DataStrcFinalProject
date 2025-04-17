using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSProject
{
    public class Product
    {
        private int code;
        private string name;
        private string category;
        private int quantity;
        private double price;
        private DateTime expirydate;
        private string modelname;
        private string modelnum;
        private string serialnum;
        private int threshold;
        private string stocklvl;

        public Product(int code, string name, string category, int quantity,
            double price, DateTime expirydate, string modelname, string modelnum,
            string serialnum, int threshold, string stocklvl)
        {
            this.code = code;
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.price = price;
            this.expirydate = expirydate;
            this.modelname = modelname;
            this.modelnum = modelnum;
            this.serialnum = serialnum;
            this.threshold = threshold;
            this.stocklvl = stocklvl;
        }

        public void Display()
        {
            //
        }

        public override string ToString()
        {
            return $"Product Code: {code},  Product Name: {name}, Category: {category}, "+
                   $"Quantity: {quantity}, Price: {price}, Expiry Date: {expirydate}" +
                   $"Model: {modelname}, Model No: {modelnum}, Serial No: {serialnum}, " +
                   $"Threshold: {threshold}, Stock Level: {stocklvl}";
        }
    }
}
