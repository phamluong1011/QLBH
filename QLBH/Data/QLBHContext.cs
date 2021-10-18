using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH.Data
{
    public class QLBHContext : DbContext
    {
        public QLBHContext(DbContextOptions<QLBHContext> options) : base(options)
        {
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>().ToTable("SanPham");
            modelBuilder.Entity<HoaDon>().ToTable("HoaDon");
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien");
        }
    }
}
    