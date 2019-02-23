﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.EntityConfiguration;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public BillsPaymentSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public BillsPaymentSystemContext()
        {
        }

        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankAccountConfig());
            modelBuilder.ApplyConfiguration(new CreditCardConfig());
        }
    }
}
