using System;
using System.Runtime.Serialization;

namespace BankApplication
{
    [Serializable]
    public class Transaction : ISerializable
    {

        public string Note { get; set; }
        public Decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string TxnId { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Note", Note);
            info.AddValue("Amount", Amount);
            info.AddValue("Date", Date);
            info.AddValue("TxnId", TxnId);
        }

        public Transaction() { }

        public Transaction(SerializationInfo info, StreamingContext context)
        {
            Note = (string)info.GetValue("Note", typeof(string));
            Amount = (Decimal)info.GetValue("Amount", typeof(Decimal));
            Date = (DateTime)info.GetValue("Date", typeof(DateTime));
            TxnId = (string)info.GetValue("TxnId", typeof(string));
        }
    }
}
