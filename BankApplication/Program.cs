using System;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            UserFlow flow = new UserFlow();
            flow.DisplayMainMenu();
        }
    }
}