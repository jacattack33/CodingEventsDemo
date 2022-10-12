using System;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; } // read only , only event class can interact bc no set, value can only be assigned in constructor
        private static int nextId = 1; //lowercase bc not assigning accessor methods, static counter variable

        public Event()
        {
            Id = nextId; //set to value when created
            nextId++; // to incrementally create unique id for each Event object
        }

        public Event(string name, string description): this()
        {
            Name = name;
            Description = description;
        }


        public override string ToString()
        {
            return Name;
        }


        //best practice to generate these for any custom classes
        //only used ID, since it's unique its a good candidate to be comparer
        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
