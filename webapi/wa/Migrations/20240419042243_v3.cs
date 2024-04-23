using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wa.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHetHan",
                table: "SanPhams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true
            );

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "KhachHangs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true
            );

            migrationBuilder.AlterColumn<string>(
                name: "DonViTinh",
                table: "ChiTietHoaDons",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayHetHan",
                table: "SanPhams",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2"
            );

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "KhachHangs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true
            );

            migrationBuilder.AlterColumn<string>(
                name: "DonViTinh",
                table: "ChiTietHoaDons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true
            );
        }
    }
}
