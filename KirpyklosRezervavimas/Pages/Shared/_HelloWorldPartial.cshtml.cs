using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SalonWithRazor.Pages.Shared
{
    public class _HelloWorldPartialModel : PageModel
    {

        public string Stringas { get; set; }
        public void OnGet()
        {
            Stringas = "labas";
        }
    }
}
