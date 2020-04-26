using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eQuanLyNhanSu.Data.EF
{
    public class EQuanLyNhanVienDbContextFactory : IDesignTimeDbContextFactory<EQuanLyNhanVienDbContext>
    {
        public EQuanLyNhanVienDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eQuanLyNhanVienDb");
            var optionsBuilder = new DbContextOptionsBuilder<EQuanLyNhanVienDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EQuanLyNhanVienDbContext(optionsBuilder.Options);
        }
    }
}
