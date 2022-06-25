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
    public class IndexModel : PageModel
    {
        private readonly EventsApp.Data.EventsAppContext _context;

        public IndexModel(EventsApp.Data.EventsAppContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {

            var events = from e in _context.Event
                         select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                events = events.Where(s => s.Title.Contains(SearchString) || s.ArabicTitle.Contains(SearchString));
            }

            Event = await events.ToListAsync();
            //Event = await _context.Event.ToListAsync();

        }
    }
}
