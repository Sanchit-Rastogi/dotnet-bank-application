using System;
namespace BankApplication.Services
{
    public class UserLoginServices
    {
        BankData bankData;
        public UserLoginServices(BankData bankData)
        {
            this.bankData = bankData;
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
                Role = role == "S" ? "Staff" : "Account Holder",
            };
           
            BankApplication bankApp = new BankApplication(bankData);
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
