using System;
namespace BankApplication.Services
{
    public class BankServices
    {
        Bank myBank;
        public BankServices(Bank bank)
        {
            this.myBank = bank;
        }

        public void RegisterBank()
        {
            Console.WriteLine("Enter your bank name");
            string name = Console.ReadLine();
            myBank.Name = name;
            myBank.DefaultCurrency = "INR";
            myBank.Id = name.AsSpan(0, 3).ToString() + DateTime.Now.ToShortDateString();
            myBank.SameBankRTGSCharge = 0;
            myBank.SameBankIMPSCharge = 5;
            myBank.DifferentBankRTGSCharge = 2;
            myBank.DifferentBankIMPSCharge = 6;
            BankApplication bankApp = new BankApplication(myBank);
            Console.WriteLine("Bank with the name " + name + " is successfully registered !");
            bankApp.DisplayMainMenu();
        }
    }
}
