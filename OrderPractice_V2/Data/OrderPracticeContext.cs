using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Models;

namespace OrderPractice_V2.Data
{
    public class OrderPracticeContext : DbContext
    {
        public OrderPracticeContext(DbContextOptions<OrderPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShipInfo> ShipInfoes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // composite key
            modelBuilder.Entity<OrderDetail>()
                .HasKey(cKey => new { cKey.OrderId, cKey.ProductId });

            // seed data
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Product1", UnitPrice = 100 },
                new Product { ProductId = 2, ProductName = "Product2", UnitPrice = 120 },
                new Product { ProductId = 3, ProductName = "Product3", UnitPrice = 200 },
                new Product { ProductId = 4, ProductName = "Product4", UnitPrice = 150 }
                );
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "UserA", Password = "123456" }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = "A20202026001", UserId = 1, TotalPrice = 100, TotalCost = 90, OrderStatus = "Payment completed" },
                new Order { OrderId = "A20202026002", UserId = 1, TotalPrice = 120, TotalCost = 100, OrderStatus = "Payment completed" },
                new Order { OrderId = "A20202026003", UserId = 1, TotalPrice = 200, TotalCost = 150, OrderStatus = "Payment completed" },
                new Order { OrderId = "A20202026004", UserId = 1, TotalPrice = 150, TotalCost = 120, OrderStatus = "Payment completed" },
                new Order { OrderId = "A20202026005", UserId = 1, TotalPrice = 2200, TotalCost = 1760, OrderStatus = "Payment completed" }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = "A20202026001", ProductId = 1, UnitPrice = 100, UnitCost = 90, Quantity = 1 },
                new OrderDetail { OrderId = "A20202026002", ProductId = 2, UnitPrice = 120, UnitCost = 100, Quantity = 1 },
                new OrderDetail { OrderId = "A20202026003", ProductId = 3, UnitPrice = 200, UnitCost = 150, Quantity = 1 },
                new OrderDetail { OrderId = "A20202026004", ProductId = 4, UnitPrice = 150, UnitCost = 120, Quantity = 1 },
                new OrderDetail { OrderId = "A20202026005", ProductId = 1, UnitPrice = 100, UnitCost = 90, Quantity = 4 },
                new OrderDetail { OrderId = "A20202026005", ProductId = 2, UnitPrice = 120, UnitCost = 100, Quantity = 5 },
                new OrderDetail { OrderId = "A20202026005", ProductId = 3, UnitPrice = 200, UnitCost = 150, Quantity = 6 }
                );
        }
    }
}
