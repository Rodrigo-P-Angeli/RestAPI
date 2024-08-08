using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Entities;

namespace RestAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() 
        {
            
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }

    }
}
