
using Microsoft.EntityFrameworkCore;
using WebApi_Oracle.Models;

namespace WebApi_Oracle.AccessData.Persistence
{
    public class AppDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=SYSTEM;Password=Ora_101_cle;");     
        }
    }
}
