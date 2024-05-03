using Microsoft.EntityFrameworkCore;

namespace wa.Models;

public class CuaHangContext : DbContext
{
    public DbSet<LoaiSanPham>? LoaiSanPhams { get; set; }
    public DbSet<SanPham>? SanPhams { get; set; }
    public DbSet<KhachHang>? KhachHangs { get; set; }
    public DbSet<HoaDon>? HoaDons { get; set; }
    public DbSet<ChiTietHoaDon>? ChiTietHoaDons { get; set; }

    private string connectString =
        @"
        Server=localhost,1433;
        Database=CuaHang;
        User=SA;
        Password=Password123;
        TrustServerCertificate=True;
    ";

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder
    )
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(connectString);
    }
}
