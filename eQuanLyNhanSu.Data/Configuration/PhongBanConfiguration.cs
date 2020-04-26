using eQuanLyNhanSu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.Configuration
{
    public class PhongBanConfiguration : IEntityTypeConfiguration<PhongBan>
    {
        public void Configure(EntityTypeBuilder<PhongBan> builder)
        {
            builder.ToTable("PhongBans");
            builder.HasKey(x => x.MaPb);
            builder.Property(x => x.MaPb).UseIdentityColumn();
            builder.Property(x => x.TenPhongBan).IsRequired();
            builder.Property(x => x.SDT).IsRequired();
        }
    }
}
