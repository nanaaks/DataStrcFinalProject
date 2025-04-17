using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSProject
{
    internal class FoodProductBuilder : IProductBuilder
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

        public Product Build()
        {
            return new Product(code, name, category, quantity, price, expirydate,
                modelname, modelnum, serialnum, threshold, stocklvl);
        }

        public IProductBuilder SetCode(int code)
        {
            this.code = code;
            return this;
        }

        public IProductBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public IProductBuilder SetCategory(string category)
        {
            this.category = category;
            return this;
        }

        public IProductBuilder SetQuantity(int quantity)
        {
            this.quantity = quantity;
            return this;
        }

        public IProductBuilder SetPrice(double price)
        {
            this.price = price;
            return this;
        }

        public IProductBuilder SetExpiry(DateTime expirydate)
        {
            this.expirydate = expirydate;
            return this;
        }

        public IProductBuilder SetModel(string modelname)
        {
            this.modelname = modelname;
            return this;
        }

        public IProductBuilder SetModelNo(string modelnum)
        {
            this.modelnum = modelnum;
            return this;
        }

        public IProductBuilder SetSerialNo(string serialnum)
        {
            this.serialnum = serialnum;
            return this;
        }

        public IProductBuilder SetThreshold(int threshold)
        {
            this.threshold = threshold;
            return this;
        }

        public IProductBuilder SetStocklvl(string stocklvl)
        {
            this.stocklvl = stocklvl;
            return this;
        }

        public IProductBuilder reset()
        {
            return new FoodProductBuilder();
        }

    }
}
