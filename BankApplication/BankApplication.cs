using System;
using BankApplication.Services;

namespace BankApplication
{
    public class BankApplication
    {
        public BankApplication() { }

        AccountServices accountServices = new AccountServices();

        public void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to The Bank Application Project \n \n");
            Console.WriteLine("Please enter option from the list :- \n");
            Console.WriteLine("1. Create a Bank");
            Console.WriteLine("2. Login for Staff / Account holder");
            Console.WriteLine("3. Save and Exit");
            int res = Convert.ToInt32(Console.ReadLine());
            BankServices bankServices = new BankServices();
            switch (res)
            {
                case 1:
                    Console.WriteLine("Registereing a new bank");
                    bankServices.RegisterBank();
                    break;
                case 2:
                    DisplayLoginMenu();
                    break;
                case 3:
                    Console.WriteLine("Option 3 is under work !");
                    break;
                default:
                    Console.WriteLine("Please select a valid option !!");
                    DisplayMainMenu();
                    break;
            }
        }

        public void DisplayLoginMenu() {
            Console.Clear();
            Console.WriteLine("Please enter option from the list :- \n");
            Console.WriteLine("1. Login as a staff");
            Console.WriteLine("2. Login as a account holder");
            Console.WriteLine("3. Go Back to main menu");
            int res = Convert.ToInt32(Console.ReadLine());
            UserLoginServices userLogin = new UserLoginServices();
            switch (res)
            {
                case 1:
                    userLogin.LoginUser("S");
                    break;
                case 2:
                    userLogin.LoginUser("AH");
                    break;
                case 3:
                    Console.Clear();
                    DisplayMainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option !!");
                    DisplayLoginMenu();
                    break;
            }
        }

        public void AccountHolderMenu()
        {
            Console.WriteLine("Hi! Welcome to the Account Holder menu :- \n");
            Console.WriteLine("1. Deposite Money.");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Transfer Funds");
            Console.WriteLine("4. View Transaction History");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Console.WriteLine("Enter amount to be deposited :- ");
                    decimal amountDeposited = Convert.ToInt32(Console.ReadLine());
                    accountServices.MakeDeposite(amountDeposited, "Made a deposte", DateTime.Now);
                    break;
                case 2:
                    Console.WriteLine("Enter amount to be withdrawn :- ");
                    decimal amountWithdrawn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter note for withdrawl :- ");
                    string note = Console.ReadLine();
                    accountServices.MakeDeposite(amountWithdrawn, note, DateTime.Now);
                    break;
                case 3:
                    Console.WriteLine("transfer money under work");
                    break;
                case 4:
                    accountServices.DisplayTransactions();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option !!");
                    AccountHolderMenu();
                    break;
            }
        }

        public void BankStaffMenu()
        {
            Console.Clear();
            Console.WriteLine("Hi! Welcome to the bank staff menu :- \n");
            Console.WriteLine("1. Create a new account.");
            Console.WriteLine("2. Update/Delete account.");
            Console.WriteLine("3. Add new currency.");
            Console.WriteLine("4. Add service charges for this bank.");
            Console.WriteLine("5. Add service charge for other bank.");
            Console.WriteLine("6. View transactions history.");
            Console.WriteLine("7. Revert a transaction.");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Console.WriteLine("Create a new account.");
                    break;
                case 2:
                    Console.WriteLine("Update/Delete account.");
                    break;
                case 3:
                    Console.WriteLine("Add new currency.");
                    break;
                case 4:
                    Console.WriteLine("Add service charges for this bank.");
                    break;
                case 5:
                    Console.WriteLine("Add service charge for other bank.");
                    break;
                case 6:
                    Console.WriteLine("View transactions history.");
                    break;
                case 7:
                    Console.WriteLine("Revert a transaction.");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option !!");
                    BankStaffMenu();
                    break;
            }
        }
    }
}
