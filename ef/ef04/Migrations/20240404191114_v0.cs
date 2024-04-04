using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef04.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loaiNguyenLieus",
                columns: table => new
                {
                    LoaiNguyenLieuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiNguyenLieus", x => x.LoaiNguyenLieuId);
                });

            migrationBuilder.CreateTable(
                name: "phieuThus",
                columns: table => new
                {
                    PhieuThuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NhanVienLap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieuThus", x => x.PhieuThuId);
                });

            migrationBuilder.CreateTable(
                name: "nguyenLieus",
                columns: table => new
                {
                    NguyenLieuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiNguyenLieuId = table.Column<int>(type: "int", nullable: false),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "money", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SoLuongKho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenLieus", x => x.NguyenLieuId);
                    table.ForeignKey(
                        name: "FK_nguyenLieus_loaiNguyenLieus_LoaiNguyenLieuId",
                        column: x => x.LoaiNguyenLieuId,
                        principalTable: "loaiNguyenLieus",
                        principalColumn: "LoaiNguyenLieuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietPhieus",
                columns: table => new
                {
                    ChiTietPhieuThuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenLieuId = table.Column<int>(type: "int", nullable: false),
                    PhieuThuId = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietPhieus", x => x.ChiTietPhieuThuId);
                    table.ForeignKey(
                        name: "FK_chiTietPhieus_nguyenLieus_NguyenLieuId",
                        column: x => x.NguyenLieuId,
                        principalTable: "nguyenLieus",
                        principalColumn: "NguyenLieuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietPhieus_phieuThus_PhieuThuId",
                        column: x => x.PhieuThuId,
                        principalTable: "phieuThus",
                        principalColumn: "PhieuThuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieus_NguyenLieuId",
                table: "chiTietPhieus",
                column: "NguyenLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieus_PhieuThuId",
                table: "chiTietPhieus",
                column: "PhieuThuId");

            migrationBuilder.CreateIndex(
                name: "IX_nguyenLieus_LoaiNguyenLieuId",
                table: "nguyenLieus",
                column: "LoaiNguyenLieuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietPhieus");

            migrationBuilder.DropTable(
                name: "nguyenLieus");

            migrationBuilder.DropTable(
                name: "phieuThus");

            migrationBuilder.DropTable(
                name: "loaiNguyenLieus");
        }
    }
}
