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

    private Dictionary<string, decimal> averages = new ()
            {
            averages.Add("Party", _context.MoneySpent.Select(a => a.Party).Average()),
            averages.Add("EatOut", _context.MoneySpent.Select(a => a.EatOut).Average()),
            averages.Add("Education", _context.MoneySpent.Select(a => a.Education).Average()),
            averages.Add("Personal", _context.MoneySpent.Select(a => a.Personal).Average()),
            averages.Add("Spa", _context.MoneySpent.Select(a => a.Spa).Average()),
            averages.Add("Hobby", _context.MoneySpent.Select(a => a.Hobby).Average()),
            averages.Add("Shopping", _context.MoneySpent.Select(a => a.Shopping).Average()),
            averages.Add("Vacation", _context.MoneySpent.Select(a => a.Vacation).Average()),
            averages.Add("Entertainment", _context.MoneySpent.Select(a => a.Entertainment).Average()),
            averages.Add("Donate", _context.MoneySpent.Select(a => a.Donate).Average())
    };

    }
}
