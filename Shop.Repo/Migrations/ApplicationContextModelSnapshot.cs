﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Shop.Data.Enums;
using Shop.Repo;
using System;

namespace Shop.Repo.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("DisplayOrder");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<long?>("ParentCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Shop.Data.Invoice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<decimal>("CouponDiscount");

                    b.Property<string>("CouponId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime?>("PaidDate");

                    b.Property<string>("PaidTransactionId");

                    b.Property<decimal>("ShipmentPrice");

                    b.Property<int>("Status");

                    b.Property<decimal>("TotalProductPrice");

                    b.Property<int>("UserId");

                    b.Property<long?>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Shop.Data.InvoiceItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<decimal>("Discount");

                    b.Property<int>("InvoiceId");

                    b.Property<long?>("InvoiceId1");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<long?>("ProductId1");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId1");

                    b.HasIndex("ProductId1");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("Shop.Data.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Barcode");

                    b.Property<int>("CategoryId");

                    b.Property<long?>("CategoryId1");

                    b.Property<decimal>("Discount");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop.Data.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shop.Data.Category", b =>
                {
                    b.HasOne("Shop.Data.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("Shop.Data.Invoice", b =>
                {
                    b.HasOne("Shop.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Shop.Data.InvoiceItem", b =>
                {
                    b.HasOne("Shop.Data.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId1");

                    b.HasOne("Shop.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Shop.Data.Product", b =>
                {
                    b.HasOne("Shop.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId1");
                });
#pragma warning restore 612, 618
        }
    }
}