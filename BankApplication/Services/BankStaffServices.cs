using System;
namespace BankApplication
{
    public class BankStaffServices
    {
        BankData bankData;
        public BankStaffServices(BankData bankData)
        {
            this.bankData = bankData;
        }

        public void UpdateAccount()
        {
            foreach (var User in bankData.UserList) {
                Console.WriteLine(User.Name + " is a " + User.Role);
            }
           
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
            BankApplication bankApplication = new BankApplication(bankData);
            bankApplication.BankStaffMenu();
        }


    }
}
