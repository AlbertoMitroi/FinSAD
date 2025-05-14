using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FinSAD.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataDbContext>
    {
        public DataDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-F0OCVK2\\SQLEXPRESS;Database=FinSAD;Integrated Security=true;MultipleActiveResultSets=True;Connection Timeout=30;Encrypt=False;TrustServerCertificate=True;");

            return new DataDbContext(optionsBuilder.Options);
        }
    }
}
