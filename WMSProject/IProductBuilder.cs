using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSProject
{
    internal interface IProductBuilder
    {
        IProductBuilder SetCode(int code);
        IProductBuilder SetName(string name);
        IProductBuilder SetCategory(string category);
        IProductBuilder SetQuantity(int quantity);
        IProductBuilder SetPrice(double price);
        IProductBuilder SetExpiry(DateTime expirydate);
        IProductBuilder SetModel(string modelname);
        IProductBuilder SetModelNo(string modelnum);
        IProductBuilder SetSerialNo(string serialnum);
        IProductBuilder SetThreshold(int threshold);
        IProductBuilder SetStocklvl(string stocklvl);
        Product Build();
        IProductBuilder reset();
    }
}
