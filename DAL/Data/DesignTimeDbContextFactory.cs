// Kafo.DAL/Data/DesignTimeDbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();

            // Use the same connection string as in your Startup
            optionsBuilder.UseSqlServer("Data Source=STEVEN\\SQLEXPRESS;Initial Catalog=SAKAN;Persist Security Info=True;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True");

            return new Context(optionsBuilder.Options);
        }
    }
}