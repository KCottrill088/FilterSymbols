using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilterSymbols.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Contact FilterZilla.";
        }
    }
}
