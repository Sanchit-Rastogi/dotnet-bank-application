using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class Account
    {
        public String Name { get; }

        public String AccId { get; }

        public Decimal Balance
        {
            get
            {
                Decimal bal = 0;
                foreach (var transaction in allTransaction)
                {
                    bal += transaction.Amount;
                }
                return bal;
            }
        }

        private List<Transaction> allTransaction = new List<Transaction>();

        public Account(String name)
        {
            Name = name;
            AccId = name.AsSpan(0, 3).ToString() + DateTime.Now.ToLongDateString();
        }

        public Account() { }

      

        public void MakeDeposite(decimal amount, String note, DateTime date)
        {
            if (amount > 0)
            {
                String id = "TXN" + AccId + DateTime.Now.ToLongDateString();
                var deposite = new Transaction(amount, note, date, id);
                allTransaction.Add(deposite);
                Console.Clear();
                Console.WriteLine("Amount deposited successfully");
                Console.WriteLine("Current Balance " + Balance.ToString());
                UserFlow flow = new UserFlow();
                flow.AccountHolderMenu();
            }
        }

        public void MakeWithdrawal(decimal amount, String note, DateTime date)
        {
            if (Balance - amount > 0)
            {
                String id = "TXN" + AccId + DateTime.Now.ToLongDateString();
                var withdrawal = new Transaction(-amount, note, date, id);
                allTransaction.Add(withdrawal);
                Console.Clear();
                Console.WriteLine("Amount withdrawn successfully");
                Console.WriteLine("Current Balance " + Balance.ToString());
                UserFlow flow = new UserFlow();
                flow.AccountHolderMenu();
            }
        }

        public void DisplayTransactions()
        {
            Console.WriteLine("TXN ID \t\t NOTE \t\t AMOUNT \t\t DATE");
            foreach(var transaction in allTransaction){
                Console.WriteLine($"{transaction.TxnId} \t\t {transaction.Note} \t\t {transaction.Amount} \t\t {transaction.Date}");
            }
            Console.WriteLine("");
            Console.WriteLine("Enter something to go back");
            String res = Console.ReadLine();
            switch (res)
            {
                default:
                    Console.Clear();
                    UserFlow flow = new UserFlow();
                    flow.AccountHolderMenu();
                    break;
            }
        }
    }
}
