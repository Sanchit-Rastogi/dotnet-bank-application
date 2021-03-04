using System;
using System.IO;
using System.Xml.Serialization;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            BankApplication BankApp = new BankApplication();
            BankApp.DisplayMainMenu();
        }
    }
}
