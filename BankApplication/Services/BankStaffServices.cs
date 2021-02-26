using System;
namespace BankApplication
{
    public class BankStaffServices
    {
        //BankData bankData;
        //public BankStaffServices(BankData bankData)
        //{
        //    this.bankData = bankData;
        //}

        Bank bank = new Bank();

        public void UpdateAccount()
        {
            //foreach (var User in bank.UserList) {
            //    Console.WriteLine(User.Name + " is a " + User.Role);
            //}
           
        }

        public void AddNewCurrency()
        {
            Console.Clear();
            Console.WriteLine("Enter currency symbole");
            string sym = Console.ReadLine();
            Console.WriteLine("Enter currecy exchange rate in INR");
            decimal rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"New currency {sym} added with exchange rate of ${rate}");
            Console.WriteLine("Press Enter to go back to main menu");
            Console.ReadLine();
            BankApplication bankApplication = new BankApplication();
            bankApplication.BankStaffMenu();
        }


    }
}
