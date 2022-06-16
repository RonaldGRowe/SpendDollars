
namespace SpendDollars.Pages

{
    public class GetAverage
    {
        public Dictionary<string, decimal>? Averages { get; set; }
        public string[] AllTopics;
        private readonly Data.MoneyDbContext _context;


        public GetAverage(Data.MoneyDbContext context)
        {
            _context = context;
            this.AllTopics = SpendDollars.Pages.IndexModel.topics;
            ColumnAverage();
        }
        private void ColumnAverage()
        {
            this.Averages.Add("Donate", _context.MoneySpent.Select(a => a.Donate).Average());
            this.Averages.Add("Party", _context.MoneySpent.Select(a => a.Party).Average());
            this.Averages.Add("EatOut", _context.MoneySpent.Select(a => a.EatOut).Average());
            this.Averages.Add("Education", _context.MoneySpent.Select(a => a.Education).Average());
            this.Averages.Add("Personal", _context.MoneySpent.Select(a => a.Personal).Average());
            this.Averages.Add("Spa", _context.MoneySpent.Select(a => a.Spa).Average());
            this.Averages.Add("Hobby", _context.MoneySpent.Select(a => a.Hobby).Average());
            this.Averages.Add("Shopping", _context.MoneySpent.Select(a => a.Shopping).Average());
            this.Averages.Add("Vacation", _context.MoneySpent.Select(a => a.Vacation).Average());
            this.Averages.Add("Entertainment", _context.MoneySpent.Select(a => a.Entertainment).Average());

        
        }
    }
}
