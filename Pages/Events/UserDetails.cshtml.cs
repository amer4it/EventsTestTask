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
    public class UserDetailsModel : PageModel
    {
        private readonly EventsApp.Data.EventsAppContext _context;

        public UserDetailsModel(EventsApp.Data.EventsAppContext context)
        {
            _context = context;
        }

        public string lang { get; set; }

        public List<SelectListItem> langs { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "AR", Text = "Arabic" },
            new SelectListItem { Value = "EN", Text = "English" }
        };

        public Event Event { get; set; }

        public List<string> relatedEventsList { set; get; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.Include(e => e.RelatedEvents).FirstOrDefaultAsync(m => m.Id == id);

            relatedEventsList = new List<string>();

            if (Event.RelatedEvents != null)
            {
                foreach (var ee in Event.RelatedEvents)
                {
                    relatedEventsList.Add(_context.Event.Find(ee.RelatedEventId).Title);
                }
            }
            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
