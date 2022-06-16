using SpendDollars.Models;

namespace SpendDollars.Services
{
    public class MoneySpentService : IMoneySpentService
    {
        private readonly Data.MoneyDbContext _context;

        public MoneySpentService(Data.MoneyDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, decimal> averages { get; set; }
        
        public Dictionary<string, decimal> GetAverage()
        {
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
        public Dictionary<string, decimal> latest { get; set; }

        public Dictionary<string, decimal> GetLatest()
        {
            int max = _context.MoneySpent.Max(p => p.ID);
            averages.Add("Party",Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Party)));
            averages.Add("EatOut", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.EatOut)));
            averages.Add("Education", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Education).Average()));
            averages.Add("Personal", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Personal).Average()));
            averages.Add("Spa", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Spa).Average()));
            averages.Add("Hobby", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Hobby).Average()));
            averages.Add("Shopping", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Shopping).Average()));
            averages.Add("Vacation", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Vacation).Average()));
            averages.Add("Entertainment", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Entertainment).Average()));
            averages.Add("Donate", Convert.ToDecimal(_context.MoneySpent.Where(a => a.ID == max).Select(a => a.Donate).Average()));
            return latest;
        }

    }
}
