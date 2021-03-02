using System;
using System.Runtime.Serialization;

namespace BankApplication
{
    public class Transaction
    {
        public string Note;
        public Decimal Amount;
        public DateTime Date;
        public string TxnId;
    }
}
