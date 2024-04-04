using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef02.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuAn",
                columns: table => new
                {
                    DuAnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDuAn = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Moto = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAn", x => x.DuAnId);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    SoDienThoai = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.NhanVienId);
                });

            migrationBuilder.CreateTable(
                name: "PhanCong",
                columns: table => new
                {
                    PhanCongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    DuAnId = table.Column<int>(type: "int", nullable: false),
                    SoGioLam = table.Column<int>(type: "int", nullable: false),
                    NhanVienModelNhanVienId = table.Column<int>(type: "int", nullable: true),
                    DuAnModelDuAnId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCong", x => x.PhanCongId);
                    table.ForeignKey(
                        name: "FK_PhanCong_DuAn_DuAnModelDuAnId",
                        column: x => x.DuAnModelDuAnId,
                        principalTable: "DuAn",
                        principalColumn: "DuAnId");
                    table.ForeignKey(
                        name: "FK_PhanCong_NhanVien_NhanVienModelNhanVienId",
                        column: x => x.NhanVienModelNhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "NhanVienId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_DuAnModelDuAnId",
                table: "PhanCong",
                column: "DuAnModelDuAnId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCong_NhanVienModelNhanVienId",
                table: "PhanCong",
                column: "NhanVienModelNhanVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhanCong");

            migrationBuilder.DropTable(
                name: "DuAn");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
