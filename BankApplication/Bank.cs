using System;
namespace BankApplication
{
    public class Bank
    {
        public String Name;
        public String DefaultCurrency;
        public int SameBankRTGSCharge;
        public int SameBankIMPSCharge;
        public int DifferentBankRTGSCharge;
        public int DifferentBankIMPSCharge;

        public Bank() { }

        public Bank(String name)
        {
            Name = name;
            DefaultCurrency = "INR";
            SameBankRTGSCharge = 0;
            SameBankIMPSCharge = 5;
            DifferentBankRTGSCharge = 2;
            DifferentBankIMPSCharge = 6;
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
