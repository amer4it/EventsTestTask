using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventsApp.Data;
using EventsApp.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace EventsApp.Pages.Events
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        private readonly EventsApp.Data.EventsAppContext _context;

        public EditModel(EventsApp.Data.EventsAppContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

            //relatedEvents = getEventsList();

        }
        private IWebHostEnvironment _webHostEnvironment;

        public List<SelectListItem> getEventsList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem listItem;
            var events = from e in _context.Event
                         where e.Id != Event.Id
                         select e;
            foreach (var ee in events)
            {
                listItem = new SelectListItem { Value = ee.Id.ToString(), Text = ee.Title, Selected = (_context.RelatedEvent.Where(b => b.EventId == Event.Id).Any(bb => bb.RelatedEventId == ee.Id)) ? true : false };
                list.Add(listItem);
            }

            return list;
        }



        [BindProperty]
        public List<string> relatedEventsSelect { get; set; }

        public List<SelectListItem> relatedEvents = new List<SelectListItem>();

        

        public RelatedEvent RelatedEvent { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);
            relatedEvents = getEventsList();

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Event.Image != null)
            {
                string imagesfolder = "images/";
                imagesfolder += Event.Image.FileName;
                Event.ImagePath = imagesfolder;

                string Serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, imagesfolder);
                await Event.Image.CopyToAsync(new FileStream(Serverfolder, FileMode.Create));
            }

            Event.Status = _context.Event.Find(Event.Id).Status;
            Event.ImagePath = _context.Event.Find(Event.Id).ImagePath;

            //_context.Attach(Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _context.RelatedEvent.RemoveRange(_context.RelatedEvent.Where(r => r.EventId == Event.Id));

                foreach (var selectedID in relatedEventsSelect)
                {
                    RelatedEvent = new RelatedEvent();

                    RelatedEvent.EventId = Event.Id;
                    RelatedEvent.RelatedEventId = Convert.ToInt32(selectedID);

                    _context.RelatedEvent.Add(RelatedEvent);
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(Event.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
