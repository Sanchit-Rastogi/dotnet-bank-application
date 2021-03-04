using System;
namespace Bank.Models
{
    public class Charges
    {
        public int SameBankRTGSCharge { get; set; }

        public int SameBankIMPSCharge { get; set; }

        public int DifferentBankRTGSCharge { get; set; }

        public int DifferentBankIMPSCharge { get; set; }
    }
}
