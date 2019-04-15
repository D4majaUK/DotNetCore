using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fullDotNet.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        
        public string getVal()
        {
            return "This is a function code-behind";
        }
    }
}
