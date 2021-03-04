﻿using System;
using Bank.Services;
using Bank.Models;
using System.Collections.Generic;

namespace BankApplication
{
    public class BankApplication
    {
      
        public void DisplayMainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Welcome to The Bank Application Project \n \n");
            Console.WriteLine("Please enter option from the list :- \n");
            Console.WriteLine("1. Create a Bank");
            Console.WriteLine("2. Login for Staff / Account holder");
            Console.WriteLine("3. Exit");
            int res = Convert.ToInt32(Console.ReadLine());
            BankServices bankServices = new BankServices();
            switch (res)
            {
                case 1:
                    Console.WriteLine("Registereing a new bank");
                    bool result = bankServices.RegisterBank();
                    if (result) DisplayMainMenu();
                    break;
                case 2:
                    DisplayLoginMenu();
                    break;
                case 3:
                    Environment.Exit(0);
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
            Console.WriteLine("1. Login as a Account Holder");
            Console.WriteLine("2. Login as a Employee");
            Console.WriteLine("3. Go Back to main menu");
            int res = Convert.ToInt32(Console.ReadLine());
            UserLoginServices userLogin = new UserLoginServices();
            switch (res)
            {
                case 1:
                    bool result = userLogin.LoginUser("AH");
                    if (result) AccountHolderMenu();
                    break;
                case 2:
                    bool result1 = userLogin.LoginUser("Emp");
                    if (result1) BankStaffMenu();
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
            AccountServices accountServices = new AccountServices();
            Console.WriteLine("Hi! Welcome to the Account Holder menu :- \n");
            Console.WriteLine("1. Deposite Money.");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Transfer Funds");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. Go back to main menu");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Console.WriteLine("Enter amount to be deposited :- ");
                    decimal amountDeposited = Convert.ToInt32(Console.ReadLine());
                    bool result = accountServices.Deposite(amountDeposited, "Made a deposte", DateTime.Now);
                    if (result)
                    {
                        Console.Clear();
                        Console.WriteLine("Amount Successfully deposited");
                        AccountHolderMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Unable to deposite amount, Try again later !");
                        AccountHolderMenu();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter amount to be withdrawn :- ");
                    decimal amountWithdrawn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter note for withdrawl :- ");
                    string note = Console.ReadLine();
                    bool result1 = accountServices.Withdrawal(amountWithdrawn, note, DateTime.Now);
                    if (result1)
                    {
                        Console.Clear();
                        Console.WriteLine("Amount Successfully withdrawn");
                        AccountHolderMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Unable to withdraw amount, Try again later !");
                        AccountHolderMenu();
                    }
                    break;
                case 3:
                    Console.WriteLine("transfer money under work");
                    break;
                case 4:
                    List<Transaction> transactions = accountServices.DisplayTransactions();
                    Console.WriteLine("TXN ID \t\t NOTE \t\t AMOUNT \t\t DATE");
                    foreach (var transaction in transactions)
                    {
                        Console.WriteLine($"{transaction.TxnId} \t\t {transaction.Note} \t\t {transaction.Amount} \t\t {transaction.Date}");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Enter something to go back");
                    String result2 = Console.ReadLine();
                    switch (result2)
                    {
                        default:
                            Console.Clear();
                            AccountHolderMenu();
                            break;
                    }
                    break;
                case 5:
                    DisplayMainMenu();
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
            BankStaffServices bankStaffServices = new BankStaffServices();
            switch (res)
            {
                case 1:
                    DisplayLoginMenu();
                    break;
                case 2:
                    Console.WriteLine("Add service charges for this bank.");
                    break;
                case 3:
                    Console.WriteLine("Add service charges for this bank.");
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
