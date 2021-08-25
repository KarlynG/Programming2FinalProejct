using Microsoft.EntityFrameworkCore;
using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Contexts
{
    public class ProgrammingFinalContext : DbContext
    {
        public ProgrammingFinalContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Billing> Billing { get; set; }
        public DbSet<Entries> Entries { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
    }
    
}
