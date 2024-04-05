using Microsoft.EntityFrameworkCore;

namespace ef03.Models;

public class KhoaHocDbContext : DbContext
{
    public DbSet<NgayHoc>? ngayHocs { get; set; }
    public DbSet<KhoaHoc>? khoaHocs { get; set; }
    public DbSet<HocVien>? hocViens { get; set; }

    private const string connectionString = @"
        Server=localhost,1433;
        Database=KhoaHoc;
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
