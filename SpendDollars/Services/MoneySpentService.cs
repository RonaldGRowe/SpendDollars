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

                //latest.Add("Party", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Party));
                //latest.Add("EatOut", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.EatOut));
                //latest.Add("Education", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Education));
                //latest.Add("Personal", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Personal));
                //latest.Add("Spa", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Spa));
                //latest.Add("Hobby", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Hobby));
                //latest.Add("Shopping", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Shopping));
                //latest.Add("Vacation", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Vacation));
                //latest.Add("Entertainment", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Entertainment));
                //latest.Add("Donate", _context.MoneySpent.Where(a => a.ID == max).Select(a => a.Donate));            
            return latest;
            }
        }

    }
}
