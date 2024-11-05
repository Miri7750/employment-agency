using System;

namespace WebApplication1
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Event()
        {
            
        }

        public Event(int id, string title, DateTime start)
        {
            Id = id;
            Title = title;
            Start = start;
        }
    }
}
