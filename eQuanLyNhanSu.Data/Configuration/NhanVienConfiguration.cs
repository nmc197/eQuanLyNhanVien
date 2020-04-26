using eQuanLyNhanSu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanViens");
            builder.HasKey(x => x.MaNV );
            builder.Property(x => x.MaNV).UseIdentityColumn();
            builder.Property(x => x.TenNv).IsRequired();
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x => x.CMND).IsRequired();
            builder.Property(x => x.ChucVu).IsRequired();
            builder.HasOne(x => x.PhongBan).WithMany(pb => pb.NhanViens).HasForeignKey(x => x.MaPb);
        }
    }
}
