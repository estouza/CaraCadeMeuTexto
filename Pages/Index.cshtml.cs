using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaraCadeMeuTexto.Pages 
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Termo { get; set; }

        public void OnGet()
        {
        }
    }
}
