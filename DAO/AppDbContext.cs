using Microsoft.EntityFrameworkCore;
using CK.DAO.ENTITY;

namespace CK.DAO
{
    public class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<ThietBi> ThietBis { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                AppConfig.ConnectionString,
                ServerVersion.AutoDetect(AppConfig.ConnectionString)
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                        .ToTable("NhanVien"); // đúng với bảng MySQL bạn tạo
            modelBuilder.Entity<DichVu>().ToTable("DichVu");
            modelBuilder.Entity<Phong>().ToTable("Phong");
            modelBuilder.Entity<ThietBi>().ToTable("ThietBi");
            modelBuilder.Entity<Phong>().HasKey(p => p.PhongId);

            modelBuilder.Entity<KhachHang>()
                .ToTable("KhachHang")
                .HasOne(k => k.Phong)
                .WithMany()
                .HasForeignKey(k => k.PhongId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
