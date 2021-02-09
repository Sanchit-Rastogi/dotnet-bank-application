using System;
namespace BankApplication.Services
{
    public class UserLoginServices
    {
        public UserLoginServices()
        {
        }

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
                Role = role,
            };
            BankData bankData = new BankData();
            BankApplication bankApp = new BankApplication();
            if (bankData.UserList.Count != 0 && bankData.UserList.Contains(loginUser))
            {
                Console.Clear();
                Console.WriteLine("User successfully logged In");
                if (role == "S")
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
                bankData.UserList.Add(loginUser);
                Console.Clear();
                Console.WriteLine("New User successfully logged In");
                if (role == "S")
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
