﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ef01.Data;

#nullable disable

namespace ef01.Data.Migrations
{
    [DbContext(typeof(HocSinhContext))]
    partial class HocSinhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ef01.Models.HocSinh", b =>
                {
                    b.Property<int>("HocSinhID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocSinhID"));

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("LopID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HocSinhID");

                    b.HasIndex("LopID");

                    b.ToTable("HocSinh");
                });

            modelBuilder.Entity("ef01.Models.Lop", b =>
                {
                    b.Property<int>("LopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopID"));

                    b.Property<int>("SiSo")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("LopID");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("ef01.Models.HocSinh", b =>
                {
                    b.HasOne("ef01.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });
#pragma warning restore 612, 618
        }
    }
}
