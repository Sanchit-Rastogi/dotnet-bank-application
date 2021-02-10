using System;
using System.Collections.Generic;

namespace BankApplication
{
    public class BankData
    {
        //Type 1
        //public List<User> UserList = new List<User>();
        //public List<Transaction> AllTransaction = new List<Transaction>();

        //Type 2
        public List<User> UserList { get; set; }
        public List<Transaction> AllTransaction { get; set; }

        public BankData()
        {
            UserList = new List<User>();
            AllTransaction = new List<Transaction>();
        }

    }
}
