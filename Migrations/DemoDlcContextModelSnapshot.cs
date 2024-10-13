﻿// <auto-generated />
using System;
using DemoDLC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoDLC.Migrations
{
    [DbContext(typeof(DemoDlcContext))]
    partial class DemoDlcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoDLC.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("adminID");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstname");

                    b.Property<byte>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)1)
                        .HasColumnName("gender");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("phonenumber");

                    b.Property<string>("Photo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("photo");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("roleID");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("AdminId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("categoryID");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstname");

                    b.Property<byte?>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)1)
                        .HasColumnName("gender");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Phonenumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("phonenumber");

                    b.Property<string>("Photo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("photo");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .HasColumnType("int")
                        .HasColumnName("feedbackID");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("comment");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<string>("IsStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("is_status");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("productID");

                    b.Property<string>("Rating")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("rating");

                    b.HasKey("FeedbackId");

                    b.HasIndex("ProductId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .HasColumnType("int")
                        .HasColumnName("imageID");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("imageName");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("productID");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DemoDLC.Models.Manufacturer", b =>
                {
                    b.Property<string>("ManufacturerId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("manufacturerID");

                    b.Property<string>("Descriptions")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descriptions");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("DemoDLC.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("orderID");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<byte>("OrderStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("orderStatus");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("paymentMethodID");

                    b.Property<string>("TotalPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("totalPrice");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("orderID");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("productID");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("quantity");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DemoDLC.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("paymentMethodID");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("paymentType");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("paymentMethod", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("productID");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("categoryID");

                    b.Property<string>("Details")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("details");

                    b.Property<string>("ManufacturerId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("manufacturerID");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("productName");

                    b.Property<byte[]>("productImage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varbinary(50)")
                        .HasColumnName("photo");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("roleID");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("DemoDLC.Models.Admin", b =>
                {
                    b.HasOne("DemoDLC.Models.Role", "Role")
                        .WithMany("Admins")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_Admin_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DemoDLC.Models.Feedback", b =>
                {
                    b.HasOne("DemoDLC.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DemoDLC.Models.Image", b =>
                {
                    b.HasOne("DemoDLC.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Images_Product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DemoDLC.Models.Order", b =>
                {
                    b.HasOne("DemoDLC.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Customer");

                    b.HasOne("DemoDLC.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentMethodId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_paymentMethod");

                    b.Navigation("Customer");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("DemoDLC.Models.OrderDetail", b =>
                {
                    b.HasOne("DemoDLC.Models.Order", "Order")
                        .WithOne("OrderDetail")
                        .HasForeignKey("DemoDLC.Models.OrderDetail", "OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Order");

                    b.HasOne("DemoDLC.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DemoDLC.Models.Product", b =>
                {
                    b.HasOne("DemoDLC.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Product_Category");

                    b.HasOne("DemoDLC.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .IsRequired()
                        .HasConstraintName("FK_Product_Manufacturers");

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("DemoDLC.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DemoDLC.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DemoDLC.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DemoDLC.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("DemoDLC.Models.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DemoDLC.Models.Product", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Images");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("DemoDLC.Models.Role", b =>
                {
                    b.Navigation("Admins");
                });
#pragma warning restore 612, 618
        }
    }
}
