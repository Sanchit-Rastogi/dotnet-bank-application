using System;
namespace BankApplication
{
    public class UserFlow
    {
        public UserFlow() { }

        public void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to The Bank Application Project");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please enter option from the list :- ");
            Console.WriteLine("");
            Console.WriteLine("1. Create a Bank");
            Console.WriteLine("2. Login for Staff / Account holder");
            Console.WriteLine("3. Save and Exit");
            int res = Convert.ToInt32(Console.ReadLine());
            Bank bank = new Bank();
            switch (res)
            {
                case 1:
                    Console.WriteLine("Registereing a new bank");
                    bank.RegisterBank();
                    break;
                case 2:
                    Console.WriteLine("Option 2 is under work !");
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
    }
}
