using System;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            BankData bankData = new BankData();
            BankApplication bankApp = new BankApplication(bankData);
            bankApp.DisplayMainMenu();
        }
    }
}

// Added develope branch 
