using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using SpendDollars.Models;

namespace SpendDollars.Pages
{
    public class IndexModel : PageModel
    {

        public static readonly string[] topics = {"Vacation", "Entertainment",
            "Education", "Donate", "Spa", "Party", "Hobby", "Shopping", "EatOut", "Personal"};


        private readonly Data.MoneyDbContext _context;
        public IndexModel(Data.MoneyDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public MoneySpent? MoneySpent { get; set; }
        
       
        public void OnGet()
        {
            ViewData["topics"] = topics;

        }

        public async Task <IActionResult> OnPostAsync()
        {
            
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (MoneySpent != null) _context.MoneySpent.Add(MoneySpent);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Graph");

        }

    }


}
