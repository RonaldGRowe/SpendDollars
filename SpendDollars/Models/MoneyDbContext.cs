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
            options.UseSqlite(@"Data Source=C:\Users\Ron\source\repos\SpendDollars\SpendDollars\MoneySpent.db");
        }
    }
}
