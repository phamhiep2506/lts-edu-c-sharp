using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef01.Data.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    LopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SiSo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.LopID);
                });

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    HocSinhID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LopID = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.HocSinhID);
                    table.ForeignKey(
                        name: "FK_HocSinh_Lop_LopID",
                        column: x => x.LopID,
                        principalTable: "Lop",
                        principalColumn: "LopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_LopID",
                table: "HocSinh",
                column: "LopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.DropTable(
                name: "Lop");
        }
    }
}
