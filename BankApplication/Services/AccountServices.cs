﻿using System;
namespace BankApplication.Services
{
    public class AccountServices
    {
        public AccountServices()
        {
        }

        static User userObj = new User();
        Account acc = new Account {
            Name = userObj.Name,
            //AccId = userObj.Name.AsSpan(0, 3).ToString() + DateTime.Now.ToLongDateString(),
            AccId = "TXN" + DateTime.Now.ToLongDateString(),
        };

        public void MakeDeposite(decimal amount, string note, DateTime date)
        {
            if (amount > 0)
            {
                string id = "TXN" + acc.AccId + DateTime.Now.ToLongDateString();
                var deposite = new Transaction {
                    Amount = amount,
                    Note = note,
                    Date = date,
                    TxnId = id,
                };
                acc.AllTransaction.Add(deposite);
                Console.Clear();
                Console.WriteLine("Amount deposited successfully");
                Console.WriteLine("Current Balance " + acc.Balance.ToString());
                BankApplication bankApp = new BankApplication();
                bankApp.AccountHolderMenu();
            }
        }

        public void MakeWithdrawal(decimal amount, string note, DateTime date)
        {
            if (acc.Balance - amount > 0)
            {
                string id = "TXN" + acc.AccId + DateTime.Now.ToLongDateString();
                var withdrawal = new Transaction {
                    Amount = -amount,
                    Note = note,
                    Date = date,
                    TxnId = id,
                };
                acc.AllTransaction.Add(withdrawal);
                Console.Clear();
                Console.WriteLine("Amount withdrawn successfully");
                Console.WriteLine("Current Balance " + acc.Balance.ToString());
                BankApplication bankApp = new BankApplication();
                bankApp.AccountHolderMenu();
            }
        }

        public void DisplayTransactions()
        {
            Console.WriteLine("TXN ID \t\t NOTE \t\t AMOUNT \t\t DATE");
            foreach (var transaction in acc.AllTransaction)
            {
                Console.WriteLine($"{transaction.TxnId} \t\t {transaction.Note} \t\t {transaction.Amount} \t\t {transaction.Date}");
            }
            Console.WriteLine("");
            Console.WriteLine("Enter something to go back");
            String res = Console.ReadLine();
            switch (res)
            {
                default:
                    Console.Clear();
                    BankApplication bankApp = new BankApplication();
                    bankApp.AccountHolderMenu();
                    break;
            }
        }
    }
}
