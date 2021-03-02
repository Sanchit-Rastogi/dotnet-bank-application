using System;
using System.Collections.Generic;

namespace BankApplication.Services
{
    public class AccountServices
    {
        Bank myBank;
        public String AccId;
        public AccountServices(Bank bank)
        {
            this.myBank = bank;
        }

        public void MakeDeposite(decimal amount, string note, DateTime date)
        {
            if (amount > 0)
            {
                string id = "TXN" + AccId + DateTime.Now.ToShortTimeString();
                var deposite = new Transaction {
                    Amount = amount,
                    Note = note,
                    Date = date,
                    TxnId = id,
                };
                foreach(var user in myBank.users)
                {
                    if (user.AccId == AccId) {
                        int pos = user.transactions.Length;
                        user.transactions[pos] = deposite;
                        Console.Clear();
                        Console.WriteLine("Amount deposited successfully");
                        Console.WriteLine("Current Balance " + user.CalculateBalance(user.transactions).ToString());
                        BankApplication bankApp = new BankApplication(myBank);
                        bankApp.AccountHolderMenu();
                    }
                }
            }
        }

        public void MakeWithdrawal(decimal amount, string note, DateTime date)
        {
            foreach (var user in myBank.users)
            {
                if (user.AccId == AccId)
                {
                    if (user.CalculateBalance(user.transactions) - amount > 0)
                    {
                        string id = "TXN" + AccId + DateTime.Now.ToShortTimeString();
                        var withdrawal = new Transaction
                        {
                            Amount = -amount,
                            Note = note,
                            Date = date,
                            TxnId = id,
                        };
                        int pos = user.transactions.Length;
                        user.transactions[pos] = withdrawal;
                        Console.Clear();
                        Console.WriteLine("Amount withdrawn successfully");
                        Console.WriteLine("Current Balance " + user.CalculateBalance(user.transactions).ToString());
                        BankApplication bankApp = new BankApplication(myBank);
                        bankApp.AccountHolderMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough balance in the account");
                        Console.WriteLine("Current Balance " + user.CalculateBalance(user.transactions).ToString());
                        BankApplication bankApp = new BankApplication(myBank);
                        bankApp.AccountHolderMenu();
                    }
                }
            }
        }

        public void DisplayTransactions()
        {
            foreach (var user in myBank.users)
            {
                if (user.AccId == AccId)
                {
                    Console.WriteLine("TXN ID \t\t NOTE \t\t AMOUNT \t\t DATE");
                    foreach (var transaction in user.transactions)
                    {
                        Console.WriteLine($"{transaction.TxnId} \t\t {transaction.Note} \t\t {transaction.Amount} \t\t {transaction.Date}");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Enter something to go back");
            String res = Console.ReadLine();
            switch (res)
            {
                default:
                    Console.Clear();
                    BankApplication bankApp = new BankApplication(myBank);
                    bankApp.AccountHolderMenu();
                    break;
            }
        }
    }
}
