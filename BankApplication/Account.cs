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
                BankData bankData = new BankData();
                foreach (var transaction in bankData.AllTransaction)
                {
                    bal += transaction.Amount;
                }
                return bal;
            } 
        }
    }
}
