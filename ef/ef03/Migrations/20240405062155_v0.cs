using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef03.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoaHocs",
                columns: table => new
                {
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocPhi = table.Column<int>(type: "int", maxLength: 10000000, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoaHocs", x => x.KhoaHocId);
                });

            migrationBuilder.CreateTable(
                name: "hocViens",
                columns: table => new
                {
                    HocVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hocViens", x => x.HocVienId);
                    table.ForeignKey(
                        name: "FK_hocViens_khoaHocs_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "khoaHocs",
                        principalColumn: "KhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ngayHocs",
                columns: table => new
                {
                    NgayHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ngayHocs", x => x.NgayHocId);
                    table.ForeignKey(
                        name: "FK_ngayHocs_khoaHocs_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "khoaHocs",
                        principalColumn: "KhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hocViens_KhoaHocId",
                table: "hocViens",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_ngayHocs_KhoaHocId",
                table: "ngayHocs",
                column: "KhoaHocId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hocViens");

            migrationBuilder.DropTable(
                name: "ngayHocs");

            migrationBuilder.DropTable(
                name: "khoaHocs");
        }
    }
}
