using FilterSymbols.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FilterSymbols.Pages
{
    public class IndexModel : PageModel
    {
        private static IList<SymbolModel> _symbols;

        public IndexModel()
        {
            if (_symbols == null)
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(@"https://api.iextrading.com/1.0/ref-data/symbols").Result;
                response.EnsureSuccessStatusCode();
                var responseString = response.Content.ReadAsStringAsync().Result;
                _symbols = JsonConvert.DeserializeObject<List<SymbolModel>>(responseString);
            }
        }
        public IList<SymbolModel> Symbol { get; set; }

        public void OnGet(string searchString)
        {
            var symbols = from s in _symbols
                          select s;

            if (!string.IsNullOrEmpty(searchString))
                symbols = symbols.Where(s => s.Name.Contains(searchString));

            Symbol = symbols.ToList();
        }
    }
}
