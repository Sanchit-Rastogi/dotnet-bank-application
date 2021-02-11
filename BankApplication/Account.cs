using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class Account
    {

        BankData bankData;
        public Account(BankData bankData) {
            this.bankData = bankData;
        }

        public string Name { get; set; }

        public string AccId { get; set; }

        public Decimal Balance
        {
            get
            {
                Decimal bal = 0;
                foreach (var transaction in bankData.AllTransaction)
                {
                    bal += transaction.Amount;
                }
                return bal;
            } 
        }
    }
}
