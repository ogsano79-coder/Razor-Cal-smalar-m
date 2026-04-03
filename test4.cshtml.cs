using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class test4Model : PageModel
    {
        
        public bool GirisYaptiMi { get; set; }

        public void OnGet()
        {
            GirisYaptiMi = true; // false yapýp denet
        }


    }
}

