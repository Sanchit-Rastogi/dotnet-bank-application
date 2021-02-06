using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class Bank
    {
        public String Name;
        public String Id;
        public String DefaultCurrency;
        public int SameBankRTGSCharge;
        public int SameBankIMPSCharge;
        public int DifferentBankRTGSCharge;
        public int DifferentBankIMPSCharge;
        public List<User> userList = new List<User>();

        public Bank() { }

        public Bank(String name)
        {
            Name = name;
            DefaultCurrency = "INR";
            Id = name.AsSpan(0,3).ToString() + DateTime.Now.ToLongDateString();
            SameBankRTGSCharge = 0;
            SameBankIMPSCharge = 5;
            DifferentBankRTGSCharge = 2;
            DifferentBankIMPSCharge = 6;
            Console.WriteLine("Bank ID : " + Id);
        }

        public void RegisterBank()
        {
            Console.WriteLine("Enter your bank name");
            String name = Console.ReadLine();
            Bank obj = new Bank(name);
            UserFlow flow = new UserFlow();
            Console.WriteLine("Bank with the name " + name + " is successfully registered !");
            flow.DisplayMainMenu();
        }
    }
}
