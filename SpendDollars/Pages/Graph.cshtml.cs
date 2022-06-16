using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SpendDollars.Models;

namespace SpendDollars.Pages
{
    public class GraphModel : PageModel
    {
        public Dictionary<string, decimal> Averages { get; set; }
        private readonly Data.MoneyDbContext _context;
        public string[] AllTopics;

        public GraphModel(Data.MoneyDbContext context)
        {
            this.AllTopics = IndexModel.topics;
            _context = context;

        }


        public int? DBCount { get; set; }
        public decimal DonateAvg { get; set; }
        public async Task OnGetAsync()
        {            
           DBCount = await _context.MoneySpent.CountAsync();

        }

    }
}
