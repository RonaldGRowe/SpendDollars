using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpendDollars.Models;
namespace SpendDollars.Pages
{
    public class IndexModel : PageModel
    {
        public static readonly string[] topics = {"Vacation", "Entertainment", 
            "Education", "Donate", "Spa", "Party", "Hobby", "Shopping", "EatOut", "Personal"};

        [BindProperty]
        public MoneySpent Money { get; set; }
        
        public void OnGet()
        {
            ViewData["topics"] = topics;

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            
            return RedirectToPage("/Graph");
        }

    }
}
