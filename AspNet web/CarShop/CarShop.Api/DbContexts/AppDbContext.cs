using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.DbContexts
{
    public class AppDbContext: DbContext
    {
        public virtual DbSet<Car> Cars { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost; Port=5432; Database=carshop-db; User Id=postgres; Password=alijonovm;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
