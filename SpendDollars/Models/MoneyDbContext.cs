using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace SpendDollars.Models
{
    public class MoneyDbContext : DbContext
    {
        public DbSet<MoneySpent> SpentMoney { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\Users\Ron\source\repos\MoneySent.db");
        }
    }
}
