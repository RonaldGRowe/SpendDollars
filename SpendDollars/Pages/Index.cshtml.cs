using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpendDollars.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public static readonly string[] topics = {"Vacation", "Entertainment", 
            "Education", "Donate", "Spa", "Party", "Hobby", "Shopping", "Eating Out", "No Comment"};
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["topics"] = topics;

        }

    }
}
