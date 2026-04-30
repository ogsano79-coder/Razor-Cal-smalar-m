using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class test1Model : PageModel
{
    [BindProperty]
    public Student Ogrenci { get; set; }

    public string Mesaj { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        Mesaj = "Kayýt tamam: " + Ogrenci.Ad;
    }
}