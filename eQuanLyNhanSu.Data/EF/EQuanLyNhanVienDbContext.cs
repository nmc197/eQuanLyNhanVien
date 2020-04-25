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
        public DbSet<NhanVien> NhanViens { get; set; }

        public DbSet<DetailsNV> DetailsNVs { get; set; }

        public DbSet<Luong> Luongs { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
    }
}
