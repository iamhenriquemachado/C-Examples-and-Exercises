using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 
    public class BankAccount
    {
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public void Withdrawal(double withdrawal)
        {
            Balance -= withdrawal;
        }

        public double CheckBalance()
        {
            return Balance; 
        }
    }

}
