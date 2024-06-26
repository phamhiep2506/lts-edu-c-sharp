﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efc03.Models;

#nullable disable

namespace efc03.Migrations
{
    [DbContext(typeof(VatTuDbContext))]
    [Migration("20240408081902_v0")]
    partial class v0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("efc03.Models.ChiTietPhieuNhap", b =>
                {
                    b.Property<int>("ChiTietPhieuNhapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuNhapId"));

                    b.Property<int>("PhieuNhapId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuNhapId");

                    b.HasIndex("PhieuNhapId");

                    b.HasIndex("VatTuId")
                        .IsUnique();

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("efc03.Models.ChiTietPhieuXuat", b =>
                {
                    b.Property<int>("ChiTietPhieuXuatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietPhieuXuatId"));

                    b.Property<int>("PhieuXuatId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongXuat")
                        .HasColumnType("int");

                    b.Property<int>("VatTuId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietPhieuXuatId");

                    b.HasIndex("PhieuXuatId");

                    b.HasIndex("VatTuId")
                        .IsUnique();

                    b.ToTable("ChiTietPhieuXuat");
                });

            modelBuilder.Entity("efc03.Models.PhieuNhap", b =>
                {
                    b.Property<int>("PhieuNhapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuNhapId"));

                    b.Property<int>("MaPhieu")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PhieuNhapId");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("efc03.Models.PhieuXuat", b =>
                {
                    b.Property<int>("PhieuXuatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuXuatId"));

                    b.Property<int>("MaPhieu")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PhieuXuatId");

                    b.ToTable("PhieuXuat");
                });

            modelBuilder.Entity("efc03.Models.VatTu", b =>
                {
                    b.Property<int>("VatTuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VatTuId"));

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenVatTu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VatTuId");

                    b.ToTable("VatTu");
                });

            modelBuilder.Entity("efc03.Models.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("efc03.Models.PhieuNhap", "PhieuNhap")
                        .WithMany()
                        .HasForeignKey("PhieuNhapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efc03.Models.VatTu", null)
                        .WithOne("ChiTietPhieuNhap")
                        .HasForeignKey("efc03.Models.ChiTietPhieuNhap", "VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuNhap");
                });

            modelBuilder.Entity("efc03.Models.ChiTietPhieuXuat", b =>
                {
                    b.HasOne("efc03.Models.PhieuXuat", "PhieuXuat")
                        .WithMany()
                        .HasForeignKey("PhieuXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efc03.Models.VatTu", null)
                        .WithOne("ChiTietPhieuXuat")
                        .HasForeignKey("efc03.Models.ChiTietPhieuXuat", "VatTuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuXuat");
                });

            modelBuilder.Entity("efc03.Models.VatTu", b =>
                {
                    b.Navigation("ChiTietPhieuNhap")
                        .IsRequired();

                    b.Navigation("ChiTietPhieuXuat")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
