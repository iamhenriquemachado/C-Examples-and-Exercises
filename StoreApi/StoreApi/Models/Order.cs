using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; } 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public double OrderTotal { get; set; }
    }
}
