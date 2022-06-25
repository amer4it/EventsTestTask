using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventsApp.Data;
using EventsApp.Models;

namespace EventsApp.Pages.Events
{
    public class DeleteModel : PageModel
    {
        private readonly EventsApp.Data.EventsAppContext _context;

        public DeleteModel(EventsApp.Data.EventsAppContext context)
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
                _context.Event.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
