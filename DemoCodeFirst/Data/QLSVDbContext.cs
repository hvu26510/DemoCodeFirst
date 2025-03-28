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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().HasKey(a=>a.Id);
            modelBuilder.Entity<Account>().Property(a => a.UserName).IsRequired();
            modelBuilder.Entity<Account>().Property(a => a.Password).IsRequired();


            modelBuilder.Entity<UserProfile>()
                .HasKey(p => p.ProfileId);
            //Quan he 1-1
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Profile)
                .WithOne(p => p.account)
                .HasForeignKey<UserProfile>(p => p.AccountId);

            //Quan he 1-N
            modelBuilder.Entity<Order>()
                .HasKey(o => o.OrderId);
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Orders)
                .WithOne(o=> o.account)
                .HasForeignKey(o => o.AccountID);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<SinhVienDetail> sinhVienDetails { get; set; }

        public DbSet<ChuyenNganh> chuyenNganhs { get; set; }
    }
}
