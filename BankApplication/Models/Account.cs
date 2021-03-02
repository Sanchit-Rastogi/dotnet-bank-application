//using System;
//using System.Collections.Generic;

//namespace BankApplication
//{
//    public class Account
//    {

//        Bank bank = new Bank();

//        public string Name { get; set; }

//        public string AccId { get; set; }

//        public Decimal Balance
//        {
//            get
//            {
//                Decimal bal = 0;
//                List<Transaction> allTransactions = bank.GetTransaction();
//                foreach (var transaction in allTransactions)
//                {
//                    bal += transaction.Amount;
//                }
//                return bal;
//            } 
//        }
//    }
//}
