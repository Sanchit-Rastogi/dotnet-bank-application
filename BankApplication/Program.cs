using System;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BankApplication bankApp = new BankApplication(bank);
            bankApp.DisplayMainMenu();
        }
    }
}
