using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FilterSymbols.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Filter a list of stock ticker Symbols.";
        }
    }
}
