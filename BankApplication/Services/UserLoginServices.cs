using System;
using System.Collections.Generic;

namespace BankApplication.Services
{
    public class UserLoginServices
    {
        Bank myBank;
        public UserLoginServices(Bank bank)
        {
            this.myBank = bank;
        }

        public void LoginUser(string role)
        {
            Console.WriteLine("Enter your user name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            BankApplication bankApp = new BankApplication(myBank);
            if (role != "S")
            {
                Console.WriteLine("Got user info");

                User loginUser = new User()
                {
                    Name = name,
                    Password = password,
                };
                AccountServices accountServices = new AccountServices(myBank);
                bool flag = false;
                foreach (var user in myBank.users)
                {
                    flag = true;
                    if (user.Name == name && user.Password == password)
                    {
                        accountServices.AccId = user.AccId;
                        Console.Clear();
                        Console.WriteLine("User successfully logged In");
                        bankApp.AccountHolderMenu();
                    }
                    else
                    {
                        loginUser.AccId = myBank.Name[..3] + loginUser.Name[..3] + DateTime.Now.ToShortDateString();
                        loginUser.Balance = 0;
                        myBank.users.Add(loginUser);
                        accountServices.AccId = loginUser.AccId;
                        Console.Clear();
                        Console.WriteLine("New User successfully logged In");
                        bankApp.AccountHolderMenu();
                    }
                }
                if (!flag)
                {
                    loginUser.AccId = myBank.Name[..3] + loginUser.Name[..3] + DateTime.Now.ToShortDateString();
                    loginUser.Balance = 0;
                    myBank.users.Add(loginUser);
                    accountServices.AccId = loginUser.AccId;
                    Console.Clear();
                    Console.WriteLine("New User successfully logged In");
                    bankApp.AccountHolderMenu();
                }
            }
            else
            {
                Employee loginEmployee = new Employee()
                {
                    Name = name,
                    Password = password,
                };
                foreach (var employee in myBank.employees)
                {
                    if (employee.Name == name && employee.Password == password)
                    {
                        Console.Clear();
                        Console.WriteLine("Employee successfully logged In");
                        bankApp.BankStaffMenu();
                    }
                    else
                    {
                        myBank.employees.Add(loginEmployee);
                        Console.Clear();
                        Console.WriteLine("Employee successfully logged In");
                        bankApp.BankStaffMenu();
                    }
                }
            }
        }
    }
}
