using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApi.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }
    }
}
