using System;
using CursoProgramacao;

namespace Course {
    class Program {
        static void Main(string[] args) {

            BankAccount bank = new BankAccount();

            Console.WriteLine("Insert account number: ");
            bank.AccountNumber = Console.ReadLine();

            Console.WriteLine("Insert the account holder: ");
            bank.AccountHolder = Console.ReadLine();

            Console.WriteLine("Insert the initial deposit: ");
            decimal initialDeposit;
            while (!decimal.TryParse(Console.ReadLine(), out initialDeposit)) {
                Console.WriteLine("Invalid input. Please enter a valid decimal value for the initial deposit:");
            }
            bank.Deposit(initialDeposit);

            Console.WriteLine("Insert the initial deposit: ");
            decimal withdrawAmmount;
            while (!decimal.TryParse(Console.ReadLine(), out withdrawAmmount) || withdrawAmmount < 0) {
                Console.WriteLine("Invalid input. Please enter a valid non-negative value:");
            }

            bank.Withdraw(withdrawAmmount);

            Console.WriteLine($"Account created successfully! Balance: {bank.GetBalance()}");
        }
    }
}