using System;
namespace BankApplication
{
    public class Transaction
    {

        public String Note;
        public Decimal Amount;
        public DateTime Date;
        public String TxnId;

        public Transaction(Decimal amount, String note, DateTime date, String txnId)
        {
            Note = note;
            Amount = amount;
            Date = date;
            TxnId = txnId;
        }
    }
}
