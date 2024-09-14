using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskef.models;

namespace taskef.data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sale> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=•\tP01_SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .HasMaxLength(50)
                .IsUnicode(true);
            modelBuilder.Entity<Customer>()
               .Property(e => e.name)
               .HasMaxLength(100)
               .IsUnicode(true);
            modelBuilder.Entity<Customer>()
               .Property(e => e.email)
               .HasMaxLength(80)
               .IsUnicode(false);
            modelBuilder.Entity<Store>()
              .Property(e => e.Name)
              .HasMaxLength(80)
              .IsUnicode(true);
        }
    }
}
