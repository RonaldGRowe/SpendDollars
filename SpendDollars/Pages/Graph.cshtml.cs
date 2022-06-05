using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpendDollars.Models;

namespace SpendDollars.Pages
{
    public class GraphModel : PageModel
    {

        private readonly Data.MoneyDbContext _context;
        public GraphModel(Data.MoneyDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public MoneySpent? MoneySpent { get; set; }
        public void OnGet()
        {
        }
    }
}
