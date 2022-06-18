using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Models;

namespace WebBanThucAn.Models
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            base.OnModelCreating(optionsBuilder);
            foreach (var entityType in optionsBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
            optionsBuilder.Entity<Category>(entity => {
                entity.HasIndex(p => p.Slug);
            });
            optionsBuilder.Entity<ProductNCategoryProduct>(entity => {
                entity.HasKey(p => new { p.ProductID, p.CategoryID });
            });
            optionsBuilder.Entity<MonAn>().HasData(
                new MonAn()
                {
                    Id = 1,
                    Name = "Hambergur",
                    Gia = 59000,
                    Quantity = 30,
                    phanLoai = MonAn.PhanLoai.DoAnNhanh,
                    //Hinh = "f2.png",
                    MoTa = "Hambergur",
                    TrangThai = true,
                },
                new MonAn()
                {
                    Id = 2,
                    Name = "Pizza",
                    Gia = 394000,
                    Quantity = 30,
                    phanLoai = MonAn.PhanLoai.DoAnNhanh,
                    //Hinh = "f3.png",
                    MoTa = "Pizza",
                    TrangThai = true,
                },
                new MonAn()
                {
                    Id = 3,
                    Name = "Khoai tây chiên",
                    Gia = 230000,
                    Quantity = 30,
                    phanLoai = MonAn.PhanLoai.DoAnNhanh,
                    //Hinh = "f5.png",
                    MoTa = "Khoai tây chiên",
                    TrangThai = true,
                },
                new MonAn()
                {
                    Id = 4,
                    Name = "Mỳ ống",
                    Gia = 417000,
                    Quantity = 30,
                    phanLoai = MonAn.PhanLoai.DoAnNhanh,
                    //Hinh = "f4.png",
                    MoTa = "Mỳ ống",
                    TrangThai = true,
                }
                );
        }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<Nguoidung> NguoiDungs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<KhachHang> DonHanKhachHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductNCategoryProduct> ProductNCategoryProducts { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }

    }
}
