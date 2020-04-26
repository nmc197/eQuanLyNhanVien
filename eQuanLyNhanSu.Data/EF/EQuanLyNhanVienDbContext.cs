using eQuanLyNhanSu.Data.Configuration;
using eQuanLyNhanSu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.EF
{
    public class EQuanLyNhanVienDbContext : DbContext
    {
        public EQuanLyNhanVienDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new LuongConfiguration());
            modelBuilder.ApplyConfiguration(new HopDongConfiguration());
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DetailsNV> DetailsNVs { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }

      
    }
}
