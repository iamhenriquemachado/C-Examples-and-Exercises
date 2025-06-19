using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApi.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Fix: Corrected method signature and implementation  
        public void CreateCustomer(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return "Customer Id: " + Id + " - " + "Customer Name: " + Name + " - " + "Customer Email: " + Email;
        }
    }
}
