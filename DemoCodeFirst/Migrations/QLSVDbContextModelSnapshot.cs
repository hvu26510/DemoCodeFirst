﻿// <auto-generated />
using System;
using DemoCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    [DbContext(typeof(QLSVDbContext))]
    partial class QLSVDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoCodeFirst.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.ChuyenNganh", b =>
                {
                    b.Property<int>("idChuyenNganh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idChuyenNganh"));

                    b.Property<string>("TenNganh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idChuyenNganh");

                    b.ToTable("chuyenNganhs");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("AccountID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamSinh")
                        .HasColumnType("int")
                        .HasColumnName("YearOfBirth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idChuyenNganh")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idChuyenNganh");

                    b.ToTable("Student", "Guest");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.SinhVienDetail", b =>
                {
                    b.Property<int>("MaSV")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSV");

                    b.ToTable("StudentDetails", "Guest");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.UserProfile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.Order", b =>
                {
                    b.HasOne("DemoCodeFirst.Models.Account", "account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.SinhVien", b =>
                {
                    b.HasOne("DemoCodeFirst.Models.ChuyenNganh", "chuyenNganh")
                        .WithMany("sinhViens")
                        .HasForeignKey("idChuyenNganh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chuyenNganh");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.SinhVienDetail", b =>
                {
                    b.HasOne("DemoCodeFirst.Models.SinhVien", "sv")
                        .WithMany()
                        .HasForeignKey("MaSV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sv");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.UserProfile", b =>
                {
                    b.HasOne("DemoCodeFirst.Models.Account", "account")
                        .WithOne("Profile")
                        .HasForeignKey("DemoCodeFirst.Models.UserProfile", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("DemoCodeFirst.Models.Account", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("DemoCodeFirst.Models.ChuyenNganh", b =>
                {
                    b.Navigation("sinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
