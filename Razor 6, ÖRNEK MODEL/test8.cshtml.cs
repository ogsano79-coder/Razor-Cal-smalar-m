using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication5.Pages.Models;
namespace WebApplication5.Pages

{
    public class test8Model : PageModel
    {

        public string isim { get; set; }
        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student
            {
                Ad = "Ýsmail",
                Ortalama = 99,
                Yas = 18,
                Uyrugu = "Türk"
            };
        }
    }
}
