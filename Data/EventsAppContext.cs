using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsApp.Models;

namespace EventsApp.Data
{
    public class EventsAppContext : DbContext
    {
        public EventsAppContext (DbContextOptions<EventsAppContext> options)
            : base(options)
        {
        }

        public DbSet<EventsApp.Models.Event> Event { get; set; }
        public DbSet<EventsApp.Models.RelatedEvent> RelatedEvent { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<RelatedEvent>().ToTable("RelatedEvent");
        }
    }
}
