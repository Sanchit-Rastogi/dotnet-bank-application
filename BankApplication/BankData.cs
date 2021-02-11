using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class BankData
    {
        public List<User> UserList { get; set; }
        public List<Transaction> AllTransaction { get; set; }

        public BankData()
        {
            UserList = new List<User>();
            AllTransaction = new List<Transaction>();
        }

    }
}
