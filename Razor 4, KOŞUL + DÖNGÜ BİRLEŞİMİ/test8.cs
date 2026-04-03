using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace test8.Pages
{
    public class test8Model : PageModel
    {
        public List<string> Isimler { get; set; }

        public void OnGet()
        {
            Isimler = new List<string>
   {
       "Ali",
       "Ayþe",
       "Mehmet",
       "Zeynep"
   };
        }

        

    }
}
