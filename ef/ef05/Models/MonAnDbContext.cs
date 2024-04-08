using Microsoft.EntityFrameworkCore;

namespace ef05.Models;

public class MonAnDbContext : DbContext
{
    public DbSet<LoaiMonAn> LoaiMonAn { get; set; }
    public DbSet<MonAn> MonAn { get; set; }
    public DbSet<CongThuc> CongThuc { get; set; }
    public DbSet<NguyenLieu> NguyenLieu { get; set; }

    private string connectString =
        @"
        Server=localhost,1433;
        Database=MonAn;
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