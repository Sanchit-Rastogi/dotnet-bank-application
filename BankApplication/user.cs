using System;
namespace BankApplication
{
    public class User
    {

        public String Name;
        private String Password;
        public String Role;

        public User() { }

        public User(String name, String password, String role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public void LoginUser(String role) {
            Console.WriteLine("Enter your user name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            String password = Console.ReadLine();
            User loginUser = new User(name, password, role);
            Bank obj = new Bank();
            UserFlow flow = new UserFlow();
            if (obj.userList.Contains(loginUser)) {
                Console.Clear();
                Console.WriteLine("User successfully logged In");
                if(role == "S")
                {
                    flow.BankStaffMenu();
                }
                else
                {
                    Account userAccount = new Account(name);
                    flow.AccountHolderMenu();
                }
            }
            else
            {
                obj.userList.Add(loginUser);
                Console.Clear();
                Console.WriteLine("New User successfully logged In");
                if (role == "S")
                {
                    flow.BankStaffMenu();
                }
                else
                {
                    Account userAccount = new Account(name);
                    flow.AccountHolderMenu();
                }
            }
        }
    }
}
