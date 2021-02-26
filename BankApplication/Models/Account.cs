using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class Account
    {

        //BankData bankData;
        //public Account(BankData bankData) {
        //    this.bankData = bankData;
        //}

        Bank bank = new Bank();

        public string Name { get; set; }

        public string AccId { get; set; }

        public Decimal Balance
        {
            get
            {
                Decimal bal = 0;
                foreach (var transaction in bank.AllTransaction)
                {
                    bal += transaction.Amount;
                }
                return bal;
            } 
        }
    }
}
