﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ef05.Models;

#nullable disable

namespace ef05.Migrations
{
    [DbContext(typeof(MonAnDbContext))]
    partial class MonAnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ef05.Models.CongThuc", b =>
                {
                    b.Property<int>("CongThucId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongThucId"));

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MonAnId")
                        .HasColumnType("int");

                    b.Property<int>("NguyenLieuId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("CongThucId");

                    b.HasIndex("MonAnId");

                    b.HasIndex("NguyenLieuId");

                    b.ToTable("CongThuc");
                });

            modelBuilder.Entity("ef05.Models.LoaiMonAn", b =>
                {
                    b.Property<int>("LoaiMonAnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoaiMonAnId"));

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LoaiMonAnId");

                    b.ToTable("LoaiMonAn");
                });

            modelBuilder.Entity("ef05.Models.MonAn", b =>
                {
                    b.Property<int>("MonAnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonAnId"));

                    b.Property<string>("CachLam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("money");

                    b.Property<string>("GioiThieu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LoaiMonAnId")
                        .HasColumnType("int");

                    b.Property<string>("TenMon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MonAnId");

                    b.HasIndex("LoaiMonAnId");

                    b.ToTable("MonAn");
                });

            modelBuilder.Entity("ef05.Models.NguyenLieu", b =>
                {
                    b.Property<int>("NguyenLieuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NguyenLieuId"));

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenNguyenLieu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("NguyenLieuId");

                    b.ToTable("NguyenLieu");
                });

            modelBuilder.Entity("ef05.Models.CongThuc", b =>
                {
                    b.HasOne("ef05.Models.MonAn", "MonAn")
                        .WithMany()
                        .HasForeignKey("MonAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ef05.Models.NguyenLieu", "NguyenLieu")
                        .WithMany()
                        .HasForeignKey("NguyenLieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonAn");

                    b.Navigation("NguyenLieu");
                });

            modelBuilder.Entity("ef05.Models.MonAn", b =>
                {
                    b.HasOne("ef05.Models.LoaiMonAn", "LoaiMonAn")
                        .WithMany()
                        .HasForeignKey("LoaiMonAnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiMonAn");
                });
#pragma warning restore 612, 618
        }
    }
}
