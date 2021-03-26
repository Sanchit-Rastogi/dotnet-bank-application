using System;
using Bank.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.Services.Data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BankDB;user=sa;password=Sanchit123@sql#;Trusted_Connection=false");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BankModel> Banks { get; set; }
    }
}
