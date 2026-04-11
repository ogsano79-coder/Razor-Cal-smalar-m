using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    public class Index1Model : PageModel
    {
        public StudentViewModel Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new StudentViewModel
            {
                Ad = "Ali",
                Soyad = "Yilmaz"
            };
        }
    }
}
