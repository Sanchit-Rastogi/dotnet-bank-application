using System;
using System.IO;
using System.Xml.Serialization;

namespace BankApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            XmlSerializer serializer = new XmlSerializer(typeof(Bank));
            FileStream fs = new FileStream("bankData.xml", FileMode.Open);
            bank = (Bank)serializer.Deserialize(fs);
            Console.WriteLine("Name of the saved bank is : " + bank.Name);
            BankApplication bankApp = new BankApplication(bank);
            bankApp.DisplayMainMenu();
        }
    }
}
