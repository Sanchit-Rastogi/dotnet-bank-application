using System;
using System.Collections.Generic;

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
        //public List<User> UserList = new List<User>();
    }
}
