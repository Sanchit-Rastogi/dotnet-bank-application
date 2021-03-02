using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BankApplication
{
    [XmlRoot("BankData", Namespace = "http://www.BankApplication.com",
    IsNullable = false)]
    public class Bank
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string DefaultCurrency { get; set; }
        public int SameBankRTGSCharge { get; set; }
        public int SameBankIMPSCharge { get; set; }
        public int DifferentBankRTGSCharge { get; set; }
        public int DifferentBankIMPSCharge { get; set; }
        [XmlArray("Users")]
        public List<User> users;
        [XmlArray("Employees")]
        public List<Employee> employees;

        public Bank()
        {
            users = new List<User>();
            employees = new List<Employee>();
        }
    }
}
