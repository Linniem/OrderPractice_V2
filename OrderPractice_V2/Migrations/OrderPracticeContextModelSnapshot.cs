﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderPractice_V2.Data;

namespace OrderPractice_V2.Migrations
{
    [DbContext(typeof(OrderPracticeContext))]
    partial class OrderPracticeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderPractice_V2.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipInfoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = "A20202026001",
                            OrderStatus = "Payment completed",
                            TotalCost = 90,
                            TotalPrice = 100,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = "A20202026002",
                            OrderStatus = "Payment completed",
                            TotalCost = 100,
                            TotalPrice = 120,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = "A20202026003",
                            OrderStatus = "Payment completed",
                            TotalCost = 150,
                            TotalPrice = 200,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = "A20202026004",
                            OrderStatus = "Payment completed",
                            TotalCost = 120,
                            TotalPrice = 150,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = "A20202026005",
                            OrderStatus = "Payment completed",
                            TotalCost = 1760,
                            TotalPrice = 2200,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("OrderPractice_V2.Models.OrderDetail", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitCost")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderId = "A20202026001",
                            ProductId = 1,
                            Quantity = 1,
                            UnitCost = 90,
                            UnitPrice = 100
                        },
                        new
                        {
                            OrderId = "A20202026002",
                            ProductId = 2,
                            Quantity = 1,
                            UnitCost = 100,
                            UnitPrice = 120
                        },
                        new
                        {
                            OrderId = "A20202026003",
                            ProductId = 3,
                            Quantity = 1,
                            UnitCost = 150,
                            UnitPrice = 200
                        },
                        new
                        {
                            OrderId = "A20202026004",
                            ProductId = 4,
                            Quantity = 1,
                            UnitCost = 120,
                            UnitPrice = 150
                        },
                        new
                        {
                            OrderId = "A20202026005",
                            ProductId = 1,
                            Quantity = 4,
                            UnitCost = 90,
                            UnitPrice = 100
                        },
                        new
                        {
                            OrderId = "A20202026005",
                            ProductId = 2,
                            Quantity = 5,
                            UnitCost = 100,
                            UnitPrice = 120
                        },
                        new
                        {
                            OrderId = "A20202026005",
                            ProductId = 3,
                            Quantity = 6,
                            UnitCost = 150,
                            UnitPrice = 200
                        });
                });

            modelBuilder.Entity("OrderPractice_V2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Product1",
                            UnitPrice = 100
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Product2",
                            UnitPrice = 120
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Product3",
                            UnitPrice = 200
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Product4",
                            UnitPrice = 150
                        });
                });

            modelBuilder.Entity("OrderPractice_V2.Models.ShipInfo", b =>
                {
                    b.Property<string>("ShipInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ShipStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipInfoId");

                    b.HasIndex("OrderId");

                    b.ToTable("ShipInfoes");
                });

            modelBuilder.Entity("OrderPractice_V2.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "123456",
                            UserName = "UserA"
                        });
                });

            modelBuilder.Entity("OrderPractice_V2.Models.Order", b =>
                {
                    b.HasOne("OrderPractice_V2.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderPractice_V2.Models.OrderDetail", b =>
                {
                    b.HasOne("OrderPractice_V2.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderPractice_V2.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderPractice_V2.Models.ShipInfo", b =>
                {
                    b.HasOne("OrderPractice_V2.Models.Order", "Order")
                        .WithMany("ShipInfos")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
