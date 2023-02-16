using EnocaCaseStudy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaCaseStudy.Persistance.Context
{
    // sealed ile farklı bir class'a kalıtım alması engelleniyor.
    public sealed class EnocaCaseStudyContext : DbContext
    {
        public EnocaCaseStudyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>()
            //    .HasOne(p => p.Company)
            //    .WithMany(p => p.Orders)
            //    .HasForeignKey(p => p.CompanyId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Company)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CompanyId);

        }
        DbSet<Company> Companies { get; set; }  
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get;set; }
    }
}
