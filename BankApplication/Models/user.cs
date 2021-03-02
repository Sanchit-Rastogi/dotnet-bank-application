using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BankApplication
{
    public class User
    {
        public string Name;
        public string AccId;
        public string Password;
        public decimal Balance;
        [XmlArray("Transactions")]
        public Transaction[] transactions;

        public decimal CalculateBalance(Transaction[] allTransactions)
        {
            foreach (var transaction in allTransactions)
            {
                Balance += transaction.Amount;
            }

            return Balance;
        }
    }
}
