using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cronycal.Pages
{
    public class BooksModel : PageModel
    {
        public string StatusMessage { get; set; } = "Your books page.";

        public void OnGet() { }
    }
}
