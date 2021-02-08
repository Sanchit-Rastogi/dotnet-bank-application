using System;
namespace BankApplication
{
    public class Transaction
    {

        public string Note { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string TxnId { get; set; }
    }
}
