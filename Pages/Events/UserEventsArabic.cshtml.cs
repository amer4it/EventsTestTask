using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Pages.Events
{
    public class UserEventsArabicModel : PageModel
    {
        private readonly EventsApp.Data.EventsAppContext _context;

        public UserEventsArabicModel(EventsApp.Data.EventsAppContext context)
        {
            _context = context;
        }

        public string lang { get; set; }

        public List<SelectListItem> langs { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "AR", Text = "Arabic" },
            new SelectListItem { Value = "EN", Text = "English" }
        };
        public IList<Event> Event { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {

            var events = from e in _context.Event
                         select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                events = events.Where(s => s.Status == 1 && s.ArabicTitle.Contains(SearchString));
            }

            Event = await events.ToListAsync();
            //Event = await _context.Event.ToListAsync();

        }
    }
}
