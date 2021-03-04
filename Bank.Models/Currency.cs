using System;
namespace Bank.Models
{
    public class Currency
    {
        public string Symbol { get; set; }

        public string Name { get; set; }

        public decimal ConversionRate { get; set; }
    }
}
