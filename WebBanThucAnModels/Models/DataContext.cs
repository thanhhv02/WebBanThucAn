using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanThucAn.Models;

namespace WebBanThucAnUser.Models
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
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
                entity.HasKey(p => new {p.ProductID,p.CategoryID });
            });
        }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<Nguoidung> NguoiDungs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<KhachHang> DonHanKhachHangs{ get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductNCategoryProduct> ProductNCategoryProducts { get; set; }

    }
}
