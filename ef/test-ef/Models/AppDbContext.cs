using Microsoft.EntityFrameworkCore;

namespace test_rf.Models;

public class AppDbContext : DbContext
{
    public DbSet<KhachHang> KhachHang { get; set; } = null!;
    public DbSet<LoaiSanPham> LoaiSanPham { get; set; } = null!;
    public DbSet<SanPham> SanPham { get; set; } = null!;
    public DbSet<DonDatHang> DonDatHang { get; set; } = null!;
    public DbSet<ChiTietDonHang> ChiTietDonHang { get; set; } = null!;

    private string connectString =
        @"
        Server=localhost,1433;
        Database=DonDatHang;
        User=SA;
        Password=Password123;
        TrustServerCertificate=True;
    ";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(connectString);
    }
}