﻿// <auto-generated />
using System;
using IMS.Plugins.EFCoreSqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Plugins.EFCoreSqlServer.Migrations
{
    [DbContext(typeof(IMSContext))]
    [Migration("20230712125454_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<string>("InventoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            InventoryName = "Case S-49",
                            Price = 129.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 2,
                            InventoryName = "M/B-X1333",
                            Price = 110.98999999999999,
                            Quantity = 8
                        },
                        new
                        {
                            InventoryId = 3,
                            InventoryName = "M/B-X1533",
                            Price = 120.98999999999999,
                            Quantity = 6
                        },
                        new
                        {
                            InventoryId = 4,
                            InventoryName = "M/B-X1933",
                            Price = 199.99000000000001,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 5,
                            InventoryName = "M/B-X2533",
                            Price = 129.99000000000001,
                            Quantity = 45
                        },
                        new
                        {
                            InventoryId = 6,
                            InventoryName = "M/B-X2733",
                            Price = 114.98999999999999,
                            Quantity = 3
                        },
                        new
                        {
                            InventoryId = 7,
                            InventoryName = "M/B-X3033",
                            Price = 129.99000000000001,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 8,
                            InventoryName = "M/B-X3133",
                            Price = 179.99000000000001,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 9,
                            InventoryName = "M/B-X3233",
                            Price = 164.99000000000001,
                            Quantity = 7
                        },
                        new
                        {
                            InventoryId = 10,
                            InventoryName = "M/B-X4333",
                            Price = 229.99000000000001,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 11,
                            InventoryName = "CPU I-30",
                            Price = 579.99000000000001,
                            Quantity = 6
                        },
                        new
                        {
                            InventoryId = 12,
                            InventoryName = "CPU I-29",
                            Price = 479.99000000000001,
                            Quantity = 8
                        },
                        new
                        {
                            InventoryId = 13,
                            InventoryName = "CPU X-400",
                            Price = 879.99000000000001,
                            Quantity = 7
                        },
                        new
                        {
                            InventoryId = 14,
                            InventoryName = "Case X-10",
                            Price = 100.98999999999999,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 15,
                            InventoryName = "Case X-21",
                            Price = 129.99000000000001,
                            Quantity = 20
                        },
                        new
                        {
                            InventoryId = 16,
                            InventoryName = "DDR10 450GB",
                            Price = 129.99000000000001,
                            Quantity = 68
                        },
                        new
                        {
                            InventoryId = 17,
                            InventoryName = "DDR12 600GB",
                            Price = 159.99000000000001,
                            Quantity = 50
                        },
                        new
                        {
                            InventoryId = 18,
                            InventoryName = "SSD 150TB",
                            Price = 199.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 19,
                            InventoryName = "RTX-7090Ti 100GB",
                            Price = 899.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 20,
                            InventoryName = "P-S 2000 Wat",
                            Price = 159.99000000000001,
                            Quantity = 46
                        },
                        new
                        {
                            InventoryId = 21,
                            InventoryName = "P-S 2200 Wat",
                            Price = 199.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 22,
                            InventoryName = "P-S 2500 Wat",
                            Price = 210.99000000000001,
                            Quantity = 8
                        },
                        new
                        {
                            InventoryId = 23,
                            InventoryName = "SSD 100TB",
                            Price = 60.990000000000002,
                            Quantity = 6
                        },
                        new
                        {
                            InventoryId = 24,
                            InventoryName = "SSD 200TB",
                            Price = 111.98999999999999,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 25,
                            InventoryName = "SSD 2500TB",
                            Price = 169.99000000000001,
                            Quantity = 45
                        },
                        new
                        {
                            InventoryId = 26,
                            InventoryName = "SSD 300TB",
                            Price = 174.99000000000001,
                            Quantity = 3
                        },
                        new
                        {
                            InventoryId = 27,
                            InventoryName = "SSD 3500TB",
                            Price = 189.99000000000001,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 28,
                            InventoryName = "RTX-5090Ti 80GB",
                            Price = 579.99000000000001,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 29,
                            InventoryName = "RTX-5090Ti 90GB",
                            Price = 664.99000000000001,
                            Quantity = 7
                        },
                        new
                        {
                            InventoryId = 30,
                            InventoryName = "M/B-X4344",
                            Price = 229.99000000000001,
                            Quantity = 15
                        },
                        new
                        {
                            InventoryId = 31,
                            InventoryName = "CPU Z-30",
                            Price = 579.99000000000001,
                            Quantity = 6
                        },
                        new
                        {
                            InventoryId = 32,
                            InventoryName = "CPU Z-29",
                            Price = 479.99000000000001,
                            Quantity = 8
                        },
                        new
                        {
                            InventoryId = 33,
                            InventoryName = "CPU K-410",
                            Price = 879.99000000000001,
                            Quantity = 7
                        },
                        new
                        {
                            InventoryId = 34,
                            InventoryName = "Case X-14",
                            Price = 100.98999999999999,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 35,
                            InventoryName = "Case X-26",
                            Price = 129.99000000000001,
                            Quantity = 20
                        },
                        new
                        {
                            InventoryId = 36,
                            InventoryName = "DDR10 350GB",
                            Price = 129.99000000000001,
                            Quantity = 68
                        },
                        new
                        {
                            InventoryId = 37,
                            InventoryName = "DDR12 200GB",
                            Price = 159.99000000000001,
                            Quantity = 50
                        },
                        new
                        {
                            InventoryId = 38,
                            InventoryName = "SSD 400TB",
                            Price = 199.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 39,
                            InventoryName = "RTX-6090Ti 100GB",
                            Price = 799.99000000000001,
                            Quantity = 12
                        },
                        new
                        {
                            InventoryId = 40,
                            InventoryName = "P-S 2500 Wat",
                            Price = 159.99000000000001,
                            Quantity = 46
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.Property<int>("InventoryTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryTransactionId"));

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("PONumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QauntityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QauntityBefore")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("InventoryTransactionId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Price = 2199.0,
                            ProductName = "Custom PC-CR1000",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            Price = 2299.0,
                            ProductName = "Custom PC-CR2000",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Price = 2599.0,
                            ProductName = "Custom PC-CR3000",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 4,
                            Price = 2699.0,
                            ProductName = "Custom PC-CR4000",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 5,
                            Price = 2799.0,
                            ProductName = "Custom PC-CR5000",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 6,
                            Price = 2299.0,
                            ProductName = "Custom PC-CR6000",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "InventoryId");

                    b.HasIndex("InventoryId");

                    b.ToTable("ProductInventories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            InventoryId = 1,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 2,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 11,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 16,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 18,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 28,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 40,
                            InventoryQuantity = 1
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.Property<int>("ProductTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductTransactionId"));

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QauntityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QauntityBefore")
                        .HasColumnType("int");

                    b.Property<string>("SONumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductTransactionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany("ProductInventories")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Navigation("ProductInventories");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Navigation("ProductInventories");
                });
#pragma warning restore 612, 618
        }
    }
}
