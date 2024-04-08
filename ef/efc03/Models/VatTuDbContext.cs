using Microsoft.EntityFrameworkCore;

namespace efc03.Models;

public class VatTuDbContext : DbContext
{
    public DbSet<VatTu> VatTu { get; set; } = null!;
    public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; } = null!;
    public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuat { get; set; } = null!;
    public DbSet<PhieuNhap> PhieuNhap { get; set; } = null!;
    public DbSet<PhieuXuat> PhieuXuat { get; set; } = null!;

    private string connectString =
        @"
        Server=localhost,1433;
        Database=VatTu;
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
