using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BankApplication
{
    public class Bank
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string DefaultCurrency { get; set; }
        public int SameBankRTGSCharge { get; set; }
        public int SameBankIMPSCharge { get; set; }
        public int DifferentBankRTGSCharge { get; set; }
        public int DifferentBankIMPSCharge { get; set; }


        //public List<User> UserList { get; set; }
        //public List<Transaction> AllTransaction { get; set; }

        public void AddTransaction(Transaction transaction)
        {

            List<Transaction> transactions = GetTransaction();
            transactions.Add(transaction);

            using Stream fs = new FileStream($"{Environment.CurrentDirectory}/transactions.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transaction>));
            serializer.Serialize(fs, transactions);

        }

        public List<Transaction> GetTransaction()
        {
            List<Transaction> transactions = null;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Transaction>));

            using (FileStream fs = File.OpenRead($"{Environment.CurrentDirectory}/transactions.xml"))
            {
                transactions = (List<Transaction>)xmlSerializer.Deserialize(fs);
            }
            return transactions;
        }


        public void AddUser(User newUser)
        {

            List<User> users = GetUsers();
            users.Add(newUser);

            using Stream fs = new FileStream($"{Environment.CurrentDirectory}/users.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            serializer.Serialize(fs, users);

        }

        public List<User> GetUsers()
        {
            List<User> users = null;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));

            using(FileStream fs = File.OpenRead($"{Environment.CurrentDirectory}/users.xml"))
            {
                users = (List<User>)xmlSerializer.Deserialize(fs);
            }
            return users;
        }
    }
}
