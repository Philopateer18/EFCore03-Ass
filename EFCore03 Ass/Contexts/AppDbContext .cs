using EFCore03_Ass.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03_Ass.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //base.OnModelCreating(modelBuilder);

            //// 🔹 One to One (Branch - Manager)
            //modelBuilder.Entity<Branch>()
            //    .HasOne(b => b.Manager)
            //    .WithOne(m => m.Branch)
            //    .HasForeignKey<Manager>(m => m.BranchId);

            //// 🔹 One to Many (Branch - Accounts)
            //modelBuilder.Entity<Account>()
            //    .HasOne(a => a.Branch)
            //    .WithMany(b => b.Accounts)
            //    .HasForeignKey(a => a.BranchId);

            //// 🔹 One to Many (Account - Transactions)
            //modelBuilder.Entity<Transaction>()
            //    .HasOne(t => t.Account)
            //    .WithMany(a => a.Transactions)
            //    .HasForeignKey(t => t.AccountId);

            //// 🔹 Many to Many (Customer - Account)
            //modelBuilder.Entity<CustomerAccount>()
            //    .HasKey(ca => new { ca.CustomerId, ca.AccountId });

            //modelBuilder.Entity<CustomerAccount>()
            //    .HasOne(ca => ca.Customer)
            //    .WithMany(c => c.CustomerAccounts)
            //    .HasForeignKey(ca => ca.CustomerId);

            //modelBuilder.Entity<CustomerAccount>()
            //    .HasOne(ca => ca.Account)
            //    .WithMany(a => a.CustomerAccounts)
            //    .HasForeignKey(ca => ca.AccountId);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BankDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
