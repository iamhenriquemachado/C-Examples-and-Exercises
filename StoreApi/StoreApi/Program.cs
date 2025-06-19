using System.Linq.Expressions;
using StoreApi.Models;

string id = "01";
string name = "Henrique";
string email = "henrique@gmail.com";

Customer customer = new Customer();
customer.CreateCustomer(id, name, email);
Console.WriteLine(customer.ToString());