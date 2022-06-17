using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using SpendDollars.Models;

namespace SpendDollars.Data

{
    public class MoneyDbContext : DbContext
    {
        public DbSet<MoneySpent> MoneySpent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=MoneySpent.db");
        }
    }
}
