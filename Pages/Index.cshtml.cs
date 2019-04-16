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
    }

    public class myMethods
    {
        public string getVal(string type)
        {
            if (type == "cb")
            {
                return "This is a function code-behind";
            } else {
                return "This is a response that I do as default";
            }
        }

    }
}
