using System;
namespace BankApplication.Services
{
    public class BankServices
    {
        public BankServices()
        {
        }

        public void RegisterBank()
        {
            Console.WriteLine("Enter your bank name");
            string name = Console.ReadLine();
            Bank bank = new Bank
            {
                Name = name,
                DefaultCurrency = "INR",
                Id = name.AsSpan(0,3).ToString() + DateTime.Now.ToLongDateString(),
                SameBankRTGSCharge = 0,
                SameBankIMPSCharge = 5,
                DifferentBankRTGSCharge = 2,
                DifferentBankIMPSCharge = 6,
            };
            BankApplication bankApp = new BankApplication();
            Console.WriteLine("Bank with the name " + name + " is successfully registered !");
            bankApp.DisplayMainMenu();
        }
    }
}
