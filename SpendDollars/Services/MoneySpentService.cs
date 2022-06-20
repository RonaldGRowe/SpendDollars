using SpendDollars.Data;
using System.Linq;

namespace SpendDollars.Services
{
    public class MoneySpentService //: IMoneySpentService
    {
        private readonly IServiceScopeFactory scopeFactory;
        public MoneySpentService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }
        
        
        public Dictionary<string, double> GetAverage()
        {
            using(var scope = scopeFactory.CreateScope())
            {
                
                var _context = scope.ServiceProvider.GetRequiredService<MoneyDbContext>();

                Dictionary<string, double> averages = new ();
                averages.Add("Party", Math.Round(_context.MoneySpent.Select(a => a.Party).Average(),2));
                averages.Add("EatOut", Math.Round(_context.MoneySpent.Select(a => a.EatOut).Average(), 2));
                averages.Add("Education", Math.Round(_context.MoneySpent.Select(a => a.Education).Average(), 2));
                averages.Add("Personal", Math.Round(_context.MoneySpent.Select(a => a.Personal).Average(), 2));
                averages.Add("Spa", Math.Round(_context.MoneySpent.Select(a => a.Spa).Average(), 2));
                averages.Add("Hobby", Math.Round(_context.MoneySpent.Select(a => a.Hobby).Average(), 2));
                averages.Add("Shopping", Math.Round(_context.MoneySpent.Select(a => a.Shopping).Average(), 2));
                averages.Add("Vacation", Math.Round(_context.MoneySpent.Select(a => a.Vacation).Average(), 2));
                averages.Add("Entertainment", Math.Round(_context.MoneySpent.Select(a => a.Entertainment).Average(), 2));
                averages.Add("Donate", Math.Round(_context.MoneySpent.Select(a => a.Donate).Average(), 2));
                return averages;
            }
                
        }                    
        

        public Dictionary<string, int> GetLatest()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var _context = scope.ServiceProvider.GetRequiredService<MoneyDbContext>();

                Dictionary<string, int> latest = new ();
                int max = _context.MoneySpent.Max(p => p.ID);
                var lastEntry = _context.MoneySpent.Where(a => a.ID == max);

                latest.Add("Party", lastEntry.Select(a => a.Party).FirstOrDefault());
                latest.Add("EatOut", lastEntry.Select(a => a.EatOut).FirstOrDefault());
                latest.Add("Education", lastEntry.Select(a => a.Education).FirstOrDefault());
                latest.Add("Personal", lastEntry.Select(a => a.Personal).FirstOrDefault());
                latest.Add("Spa", lastEntry.Select(a => a.Spa).FirstOrDefault());
                latest.Add("Hobby", lastEntry.Select(a => a.Hobby).FirstOrDefault());
                latest.Add("Shopping", lastEntry.Select(a => a.Shopping).FirstOrDefault());
                latest.Add("Vacation", lastEntry.Select(a => a.Vacation).FirstOrDefault());
                latest.Add("Entertainment", lastEntry.Select(a => a.Entertainment).FirstOrDefault());
                latest.Add("Donate", lastEntry.Select(a => a.Donate).FirstOrDefault());
                return latest;
            }
        }

    }
}
