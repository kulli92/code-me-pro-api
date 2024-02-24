﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeMePro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeMe.Pro.Models.CourierCharge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.Property<int>("MinWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CourierCharge");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Charge = 5m,
                            MaxWeight = 200,
                            MinWeight = 0
                        },
                        new
                        {
                            Id = 2,
                            Charge = 10m,
                            MaxWeight = 500,
                            MinWeight = 201
                        },
                        new
                        {
                            Id = 3,
                            Charge = 15m,
                            MaxWeight = 1000,
                            MinWeight = 501
                        },
                        new
                        {
                            Id = 4,
                            Charge = 20m,
                            MaxWeight = 5000,
                            MinWeight = 1001
                        });
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalWeight")
                        .HasColumnType("int");

                    b.HasKey("PackageId");

                    b.HasIndex("OrderId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.PackageDetail", b =>
                {
                    b.Property<int>("PackageDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PackageDetailId");

                    b.HasIndex("PackageId");

                    b.HasIndex("ProductId");

                    b.ToTable("PackageDetails");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Item 1",
                            Price = 10m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "Item 2",
                            Price = 100m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "Item 3",
                            Price = 30m,
                            Weight = 300
                        },
                        new
                        {
                            ProductId = 4,
                            Name = "Item 4",
                            Price = 20m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 5,
                            Name = "Item 5",
                            Price = 30m,
                            Weight = 250
                        },
                        new
                        {
                            ProductId = 6,
                            Name = "Item 6",
                            Price = 40m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 7,
                            Name = "Item 7",
                            Price = 200m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 8,
                            Name = "Item 8",
                            Price = 120m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 9,
                            Name = "Item 9",
                            Price = 130m,
                            Weight = 790
                        },
                        new
                        {
                            ProductId = 10,
                            Name = "Item 10",
                            Price = 20m,
                            Weight = 100
                        },
                        new
                        {
                            ProductId = 11,
                            Name = "Item 11",
                            Price = 10m,
                            Weight = 340
                        },
                        new
                        {
                            ProductId = 12,
                            Name = "Item 12",
                            Price = 4m,
                            Weight = 800
                        },
                        new
                        {
                            ProductId = 13,
                            Name = "Item 13",
                            Price = 5m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 14,
                            Name = "Item 14",
                            Price = 240m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 15,
                            Name = "Item 15",
                            Price = 123m,
                            Weight = 700
                        },
                        new
                        {
                            ProductId = 16,
                            Name = "Item 16",
                            Price = 245m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 17,
                            Name = "Item 17",
                            Price = 230m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 18,
                            Name = "Item 18",
                            Price = 110m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 19,
                            Name = "Item 19",
                            Price = 45m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 20,
                            Name = "Item 20",
                            Price = 67m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 21,
                            Name = "Item 21",
                            Price = 88m,
                            Weight = 300
                        },
                        new
                        {
                            ProductId = 22,
                            Name = "Item 22",
                            Price = 10m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 23,
                            Name = "Item 23",
                            Price = 17m,
                            Weight = 250
                        },
                        new
                        {
                            ProductId = 24,
                            Name = "Item 24",
                            Price = 19m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 25,
                            Name = "Item 25",
                            Price = 89m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 26,
                            Name = "Item 26",
                            Price = 45m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 27,
                            Name = "Item 27",
                            Price = 99m,
                            Weight = 790
                        },
                        new
                        {
                            ProductId = 28,
                            Name = "Item 28",
                            Price = 125m,
                            Weight = 100
                        },
                        new
                        {
                            ProductId = 29,
                            Name = "Item 29",
                            Price = 198m,
                            Weight = 340
                        },
                        new
                        {
                            ProductId = 30,
                            Name = "Item 30",
                            Price = 220m,
                            Weight = 800
                        },
                        new
                        {
                            ProductId = 31,
                            Name = "Item 31",
                            Price = 249m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 32,
                            Name = "Item 32",
                            Price = 230m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 33,
                            Name = "Item 33",
                            Price = 190m,
                            Weight = 700
                        },
                        new
                        {
                            ProductId = 34,
                            Name = "Item 34",
                            Price = 45m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 35,
                            Name = "Item 35",
                            Price = 12m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 36,
                            Name = "Item 36",
                            Price = 5m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 37,
                            Name = "Item 37",
                            Price = 2m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 38,
                            Name = "Item 38",
                            Price = 90m,
                            Weight = 20
                        },
                        new
                        {
                            ProductId = 39,
                            Name = "Item 39",
                            Price = 12m,
                            Weight = 300
                        },
                        new
                        {
                            ProductId = 40,
                            Name = "Item 40",
                            Price = 167m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 41,
                            Name = "Item 41",
                            Price = 12m,
                            Weight = 250
                        },
                        new
                        {
                            ProductId = 42,
                            Name = "Item 42",
                            Price = 8m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 43,
                            Name = "Item 43",
                            Price = 2m,
                            Weight = 10
                        },
                        new
                        {
                            ProductId = 44,
                            Name = "Item 44",
                            Price = 9m,
                            Weight = 500
                        },
                        new
                        {
                            ProductId = 45,
                            Name = "Item 45",
                            Price = 210m,
                            Weight = 790
                        },
                        new
                        {
                            ProductId = 46,
                            Name = "Item 46",
                            Price = 167m,
                            Weight = 100
                        },
                        new
                        {
                            ProductId = 47,
                            Name = "Item 47",
                            Price = 23m,
                            Weight = 340
                        },
                        new
                        {
                            ProductId = 48,
                            Name = "Item 48",
                            Price = 190m,
                            Weight = 800
                        },
                        new
                        {
                            ProductId = 49,
                            Name = "Item 49",
                            Price = 199m,
                            Weight = 200
                        },
                        new
                        {
                            ProductId = 50,
                            Name = "Item 50",
                            Price = 12m,
                            Weight = 20
                        });
                });

            modelBuilder.Entity("CodeMe.Pro.Models.OrderDetail", b =>
                {
                    b.HasOne("CodeMe.Pro.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeMe.Pro.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Package", b =>
                {
                    b.HasOne("CodeMe.Pro.Models.Order", "Order")
                        .WithMany("Packages")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.PackageDetail", b =>
                {
                    b.HasOne("CodeMe.Pro.Models.Package", "Package")
                        .WithMany("PackageDetails")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeMe.Pro.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Packages");
                });

            modelBuilder.Entity("CodeMe.Pro.Models.Package", b =>
                {
                    b.Navigation("PackageDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
