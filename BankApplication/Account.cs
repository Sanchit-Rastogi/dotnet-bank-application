using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class Account
    {
        public string Name { get; set; }

        public string AccId { get; set; }

        public Decimal Balance
        {
            get
            {
                Decimal bal = 0;
                foreach (var transaction in AllTransaction)
                {
                    bal += transaction.Amount;
                }
                return bal;
            } 
        }

        public List<Transaction> AllTransaction { get; set; }
    }
}
