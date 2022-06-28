using AppNet.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.Contexts
{
    public class AppNetDbContext : DbContext
    {
        public AppNetDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(DatabaseInformation.Load().ConStr);
            //            optionsBuilder.UseSqlServer(
            //"Data Source=.\\MSSQLSERVER01;Initial Catalog=AppNetDb;Persist Security Info=True;User ID=sa;Password=sa1"
            //                );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerGercek> CustomerGerceks { get; set; }
        public DbSet<CustomerTuzel> CustomerTuzels { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Safe> Safes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<DataBase> DataBases { get; set; }
    }
}
