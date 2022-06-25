using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventsApp.Data;
using EventsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace EventsApp.Pages.Events
{
    public class CreateModel : PageModel
    {
        public IList<Event> Events { get; set; }
        public IList<RelatedEvent> RelatedEvents { get; set; }

        private readonly EventsApp.Data.EventsAppContext _context;

        private IWebHostEnvironment _webHostEnvironment;

        public List<SelectListItem> getEventsList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem listItem;
            var events = from e in _context.Event
                         select e;
            foreach (var ee in events)
            {
                listItem = new SelectListItem { Value = ee.Id.ToString(), Text = ee.Title };
                list.Add(listItem);
            }

            return list;
        }
        [BindProperty]
        public List<string> relatedEventsSelect { get; set; }

        public List<SelectListItem> relatedEvents = new List<SelectListItem>();

        //public string lang { get; set; }

        //public List<SelectListItem> langs { get; } = new List<SelectListItem>
        //{

        //    new SelectListItem { Value = "EN", Text = "English" },
        //        new SelectListItem { Value = "AR", Text = "Arabic" }
        //};

        public CreateModel(EventsApp.Data.EventsAppContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            relatedEvents = getEventsList();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; }

        public RelatedEvent RelatedEvent { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Event.Image != null)
            {
                string imagesfolder = "images/";
                imagesfolder += Event.Image.FileName;
                Event.ImagePath = imagesfolder; 
                
                string Serverfolder = Path.Combine(_webHostEnvironment.WebRootPath, imagesfolder);
                await Event.Image.CopyToAsync(new FileStream(Serverfolder, FileMode.Create));
            }

            Event.Status = 1;

            _context.Event.Add(Event);
            
            await _context.SaveChangesAsync();

            foreach (var selectedID in relatedEventsSelect)
            {
                RelatedEvent = new RelatedEvent();

                RelatedEvent.EventId = Event.Id;
                RelatedEvent.RelatedEventId = Convert.ToInt32(selectedID);

                _context.RelatedEvent.Add(RelatedEvent);
            }
            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        //public List<SelectListItem> getEventsList()
        //{
        //    var events = from e in _context.Event
        //                 select e;
        //    List<Event> ee = events.ToListAsync<Event>;

        //    foreach (var e in ee)
        //    {

        //    }

        //}

        //public async IAsyncEnumerable<Event> getAllEvents()
        //{
        //     return await _context.Event.ToListAsync();

        //}
    }
}
