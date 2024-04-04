using Microsoft.EntityFrameworkCore;

namespace ef04.Models;

public class PhieuThuDBContext : DbContext
{
    public DbSet<LoaiNguyenLieu>? loaiNguyenLieus { get; set; }
    public DbSet<NguyenLieu>? nguyenLieus { get; set; }
    public DbSet<ChiTietPhieuThu>? chiTietPhieus { get; set; }
    public DbSet<PhieuThu>? phieuThus { get; set; }

    private const string connectionString = @"
        Server=localhost,1433;
        Database=PhieuThu;
        User=SA;
        Password=Password123;
        TrustServerCertificate=True;
    ";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(connectionString);
    }
}
