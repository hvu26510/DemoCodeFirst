﻿// <auto-generated />
using DemoCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    [DbContext(typeof(QLSVDbContext))]
    [Migration("20250326011549_TableNameTest")]
    partial class TableNameTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("DemoCodeFirst.Models.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

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

            modelBuilder.Entity("DemoCodeFirst.Models.ChuyenNganh", b =>
                {
                    b.Navigation("sinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
