using Microsoft.EntityFrameworkCore;
using SpendDollars.Data;
using SpendDollars.Models;

namespace SpendDollars.Services
{
    public class MoneySpentService : IMoneySpentService
    {
        private readonly IServiceScopeFactory scopeFactory;
        public MoneySpentService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }
        public Dictionary<string, int> averages { get; set; }
        
        public Dictionary<string, int> GetAverage()
        {
            using(var scope = scopeFactory.CreateScope())
            {
                var _context = scope.ServiceProvider.GetRequiredService<MoneyDbContext>();

                averages.Add("Party", _context.MoneySpent.Select(a => a.Party).Average());
                averages.Add("EatOut", _context.MoneySpent.Select(a => a.EatOut).Average());
                averages.Add("Education", _context.MoneySpent.Select(a => a.Education).Average());
                averages.Add("Personal", _context.MoneySpent.Select(a => a.Personal).Average());
                averages.Add("Spa", _context.MoneySpent.Select(a => a.Spa).Average());
                averages.Add("Hobby", _context.MoneySpent.Select(a => a.Hobby).Average());
                averages.Add("Shopping", _context.MoneySpent.Select(a => a.Shopping).Average());
                averages.Add("Vacation", _context.MoneySpent.Select(a => a.Vacation).Average());
                averages.Add("Entertainment", _context.MoneySpent.Select(a => a.Entertainment).Average());
                averages.Add("Donate", _context.MoneySpent.Select(a => a.Donate).Average());
            }
                return averages;
        }                    
        public Dictionary<string, int> latest { get; set; }

        public Dictionary<string, int> GetLatest()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var _context = scope.ServiceProvider.GetRequiredService<MoneyDbContext>();

                
                int max = _context.MoneySpent.Max(p => p.ID);

                averages.Add("Party", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Party)));
                averages.Add("EatOut", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.EatOut)));
                averages.Add("Education", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Education).Average()));
                averages.Add("Personal", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Personal).Average()));
                averages.Add("Spa", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Spa).Average()));
                averages.Add("Hobby", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Hobby).Average()));
                averages.Add("Shopping", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Shopping).Average()));
                averages.Add("Vacation", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Vacation).Average()));
                averages.Add("Entertainment", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Entertainment).Average()));
                averages.Add("Donate", Convert.Toint(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Donate).Average()));
            }
            return latest;
        }

    }
}
