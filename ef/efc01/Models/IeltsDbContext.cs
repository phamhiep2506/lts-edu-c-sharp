using Microsoft.EntityFrameworkCore;

namespace efc01.Models;

public class IeltsDbContext : DbContext
{
    public DbSet<HocVien> HocViens { get; set; } = null!;

    private string connectString =
        @"
        Server=localhost,1433;
        Database=Ielts;
        User=SA;
        Password=Password123;
        TrustServerCertificate=True;
    ";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectString);
    }
}
