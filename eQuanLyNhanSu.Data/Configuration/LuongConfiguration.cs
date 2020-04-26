using eQuanLyNhanSu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.Configuration
{
    public class LuongConfiguration : IEntityTypeConfiguration<Luong>
    {
        public void Configure(EntityTypeBuilder<Luong> builder)
        {
            builder.ToTable("Luongs");
            builder.HasKey(x => x.MaLuong);
            builder.Property(x => x.LuongCoBan).IsRequired();
            builder.Property(x => x.SoNgayLam).IsRequired();
            builder.Property(x => x.PhuCap).IsRequired();
        }
    }
}
