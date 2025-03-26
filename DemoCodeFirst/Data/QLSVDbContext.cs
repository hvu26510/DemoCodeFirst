using DemoCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoCodeFirst.Data
{
    public class QLSVDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (dbContextOptionsBuilder != null) { 
                dbContextOptionsBuilder.UseSqlServer(@"Data Source=DESKTOP-EU216N6\HVUSERVER;Initial Catalog=2603EFCodeFirst;Integrated Security=True;Trust Server Certificate=True"); 
            }
        }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<SinhVienDetail> sinhVienDetails { get; set; }

        public DbSet<ChuyenNganh> chuyenNganhs { get; set; }
    }
}
