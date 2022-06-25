using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public string lang { get; set; }

        public List<SelectListItem> langs { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "AR", Text = "Arabic" },
            new SelectListItem { Value = "EN", Text = "English" }
            //new SelectListItem { Value = "US", Text = "USA"  },
        };
        //public List<string> lang = new List<string>{"Arabic","English" };

        public void OnGet()
        {
        }
    }
}
