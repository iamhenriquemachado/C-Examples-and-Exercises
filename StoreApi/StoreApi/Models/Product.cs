using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StoreApi.Models
{
    public class Product
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "ItemCode: " + ItemCode + " - " + "ItemName: " + ItemName + " - " + "Price: " + Price;
        }
    }


}
