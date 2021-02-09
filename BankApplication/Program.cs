using System;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            BankApplication bankApp = new BankApplication();
            bankApp.DisplayMainMenu();
        }
    }
}

// Q1. While using get/set and declaring constructor is giving an error ?
// Q2. Call we call a class method with declaring a new object for it ? As it might be redeclaring all the variables ?