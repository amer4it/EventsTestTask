using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Pages.Events
{
    public class ActDeActModel : PageModel
    {
        private readonly EventsApp.Data.EventsAppContext _context;

        public ActDeActModel(EventsApp.Data.EventsAppContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FindAsync(id);

            if (Event != null)
            {
                if (Event.Status == 1)
                    Event.Status = 0;
                else
                    Event.Status = 1;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
