using Microsoft.EntityFrameworkCore;
using ef01.Models;

namespace ef01.Data
{
    public class HocSinhContext : DbContext
    {
        public DbSet<HocSinh>? HocSinh { get; set; }
        public DbSet<Lop>? Lop { get; set; }

        private const string connectionString = @"
            Server=localhost,1433;
            Database=HocSinh;
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
