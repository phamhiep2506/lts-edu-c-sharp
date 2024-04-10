using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test_ef.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachHangId = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    ),
                    DiaChi = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    SoDienThoai = table.Column<string>(
                        type: "nvarchar(15)",
                        maxLength: 15,
                        nullable: false
                    ),
                    GhiChu = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    Email = table.Column<string>(
                        type: "nvarchar(20)",
                        maxLength: 20,
                        nullable: false
                    )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.KhachHangId);
                }
            );

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    LoaiSanPhamId = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    GhiChu = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.LoaiSanPhamId);
                }
            );

            migrationBuilder.CreateTable(
                name: "DonDatHang",
                columns: table => new
                {
                    DonDatHangId = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    SoHieuDon = table.Column<int>(type: "int", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayGioTraThucTe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    TinhTrang = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatHang", x => x.DonDatHangId);
                    table.ForeignKey(
                        name: "FK_DonDatHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "KhachHangId",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamId = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPhamId = table.Column<int>(type: "int", nullable: false),
                    KyHieuSanPham = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    ),
                    TenSanPham = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    MoTa = table.Column<string>(
                        type: "nvarchar(100)",
                        maxLength: 100,
                        nullable: false
                    ),
                    NhaSanXuat = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    ),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiaBan = table.Column<decimal>(type: "money", nullable: false),
                    LaSanPhamMoi = table.Column<string>(
                        type: "nvarchar(50)",
                        maxLength: 50,
                        nullable: false
                    )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.SanPhamId);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "LoaiSanPhamId",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ChiTietDonDatHang",
                columns: table => new
                {
                    ChiTietDonDatHangId = table
                        .Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonDatHangId = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonDatHang", x => x.ChiTietDonDatHangId);
                    table.ForeignKey(
                        name: "FK_ChiTietDonDatHang_DonDatHang_DonDatHangId",
                        column: x => x.DonDatHangId,
                        principalTable: "DonDatHang",
                        principalColumn: "DonDatHangId",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_ChiTietDonDatHang_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "SanPhamId",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonDatHang_DonDatHangId",
                table: "ChiTietDonDatHang",
                column: "DonDatHangId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonDatHang_SanPhamId",
                table: "ChiTietDonDatHang",
                column: "SanPhamId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_DonDatHang_KhachHangId",
                table: "DonDatHang",
                column: "KhachHangId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamId",
                table: "SanPham",
                column: "LoaiSanPhamId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ChiTietDonDatHang");

            migrationBuilder.DropTable(name: "DonDatHang");

            migrationBuilder.DropTable(name: "SanPham");

            migrationBuilder.DropTable(name: "KhachHang");

            migrationBuilder.DropTable(name: "LoaiSanPham");
        }
    }
}
