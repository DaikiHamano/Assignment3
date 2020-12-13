using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //defining the model to access by the contorollor
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //define the relationship and keys
            //cart and request
            builder.Entity<Request>()
                .HasOne(p => p.Cart)
                .WithMany(c => c.Requests)
                .HasForeignKey(p => p.CartId)
                .HasConstraintName("Fk_Requests_CartId");

            //for order
            builder.Entity<Order>()
               .HasOne(p => p.Cart)
               .WithMany(c => c.Orders)
               .HasForeignKey(p => p.CartId)
               .HasConstraintName("Fk_Orders_CartId");
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }


}
