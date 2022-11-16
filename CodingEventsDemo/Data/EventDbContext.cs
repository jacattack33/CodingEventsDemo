using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }

           
    }
}
