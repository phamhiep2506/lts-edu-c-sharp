using Microsoft.EntityFrameworkCore;

namespace ef02.Models
{
    public class NhanVienContext : DbContext
    {
        public DbSet<NhanVienModel>? NhanVienModel { get; set; }
        public DbSet<DuAnModel>? DuAnModel { get; set; }
        public DbSet<PhanCongModel>? PhanCongModel { get; set; }

        private const string connectionString = @"
            Server=localhost,1433;
            Database=NhanVien;
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
}
