using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacao {
    internal class BankAccount {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        public string GetBalance() {
            return $"{AccountHolder} has a balance of {Balance:C}";
        }

        public string Deposit(decimal amount) {
            if (amount >= 0) {
                Balance += amount;
            }
            return $"{AccountHolder} deposited {amount:C}. New balance: {Balance:C}";
        }

        public string Withdraw(decimal amount) {
            if (amount > Balance) {
                return $"{AccountHolder} cannot withdraw {amount:C}. Insufficient funds.";
            } else {
                Balance -= amount;
                return $"{AccountHolder} withdrew {amount:C}. New balance: {Balance:C}";
            }
        }
      }
    }
