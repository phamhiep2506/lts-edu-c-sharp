using Microsoft.EntityFrameworkCore;

namespace efc02.Models;

public class CongThucNauAnDbContext : DbContext
{
    public DbSet<CongThuc> CongThuc { get; set; } = null!;
    public DbSet<NguyenLieu> NguyenLieu { get; set; } = null!;
    public DbSet<MonAn> MonAn { get; set; } = null!;
    public DbSet<LoaiMonAn> LoaiMonAn { get; set; } = null!;

    private string connectString = @"
        Server=localhost,1433;
        Database=CongThucNauAn;
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
