using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data

{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent); //key and value
        }

        // retrieve events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values; //we are just returning the events not the ID as well
        }

        // retrieve singular event
        public static Event GetById(int id)  //one argument, given this integer look into collection and  give me back object with that id
        {
            return Events[id]; //can use key itself to return the event object value
        }

        // remove event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}
