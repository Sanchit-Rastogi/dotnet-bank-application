using System;
using System.Collections.Generic;

namespace BankApplication.Services
{
    public class UserLoginServices
    {
        //BankData bankData;
        //public UserLoginServices(BankData bankData)
        //{
        //    this.bankData = bankData;
        //}

        public void LoginUser(string role)
        {
            Console.WriteLine("Enter your user name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            User loginUser = new User()
            {
                Name = name,
                Password = password,
                Role = role == "S" ? "Staff" : role == "AH" ? "Account Holder" : "Admin",
            };
           
            BankApplication bankApp = new BankApplication();
            Bank bank = new Bank();
            List<User> savedUsers = bank.GetUsers();
            if (savedUsers.Count != 0 && savedUsers.Contains(loginUser))
            {
                Console.Clear();
                Console.WriteLine("User successfully logged In");
                if (role == "S" || role == "AD")
                {
                    bankApp.BankStaffMenu();
                }
                else
                {
                    bankApp.AccountHolderMenu();
                }
            }
            else
            {
                bank.AddUser(loginUser);
                Console.Clear();
                Console.WriteLine("New User successfully logged In");
                if (role == "S" || role == "AD")
                {
                    bankApp.BankStaffMenu();
                }
                else
                {
                    bankApp.AccountHolderMenu();
                }
            }
        }
    }
}
