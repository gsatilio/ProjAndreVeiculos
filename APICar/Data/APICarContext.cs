using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APICar.Data
{
    public class APICarContext : DbContext
    {
        public APICarContext(DbContextOptions<APICarContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Car> Car { get; set; } = default!;

        public DbSet<Models.Customer>? Customer { get; set; }

        public DbSet<Models.Acquisition>? Acquisition { get; set; }

        public DbSet<Models.Address>? Address { get; set; }

        public DbSet<Models.Boleto>? Boleto { get; set; }

        public DbSet<Models.CarOperation>? CarOperation { get; set; }

        public DbSet<Models.CreditCard>? CreditCard { get; set; }

        public DbSet<Models.Employee>? Employee { get; set; }

        public DbSet<Models.Operation>? Operation { get; set; }

        public DbSet<Models.Payment>? Payment { get; set; }

        public DbSet<Models.Pix>? Pix { get; set; }

        public DbSet<Models.PixType>? PixType { get; set; }

        public DbSet<Models.Role>? Role { get; set; }

        public DbSet<Models.Sale>? Sale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasKey(p => p.Document); 
            
            */
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa
            //modelBuilder.Entity<Person>().HasKey(p => p.Document);
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
