using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace EventsApp.Models
{
    public class Event
    {
        public int Id { set; get; }
        
        public string Title { set; get; }
        public string Description { set; get; }
        public string Location { set; get; }

        [Display(Name = "Title (Arabic)")]
        public string ArabicTitle { set; get; }
        
        [Display(Name = "Description (Arabic)")]
        public string ArabicDescription { set; get; }

        [Display(Name = "Location (Arabic)")]
        public string ArabicLocation { set; get; }

        [Display(Name = "Longitude")]
        public int CoordLongitude { set; get; }

        [Display(Name = "Latitude")]
        public int CoordLatitude { set; get; }

        [Display(Name = "Image Path")]
        public string ImagePath { set; get; }

        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile Image { set; get; }


        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { set; get; }
       
        public int Status { set; get; }
        public ICollection<RelatedEvent> RelatedEvents { set; get; }
    }
}
