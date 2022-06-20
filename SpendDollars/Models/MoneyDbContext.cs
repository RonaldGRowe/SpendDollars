using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using SpendDollars.Models;

namespace SpendDollars.Data

{
    public class MoneyDbContext : DbContext
    {
        public DbSet<MoneySpent> MoneySpent { get; set; }

        public MoneyDbContext(DbContextOptions<MoneyDbContext> options)
            : base(options)
        {
        }
    }
}
