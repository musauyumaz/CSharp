using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }



        //public DbSet<Personel> Personels { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("dbo");
        //    modelBuilder.Entity<Personel>().ToTable("Employees", "dbo");
        //    modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
        //    modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
        //    modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        //}
    }
}
