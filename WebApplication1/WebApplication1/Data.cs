using System.Text.Json;

namespace WebApplication1
{
    public class Data
    {
        public static List<Event> data { get; set; }= new List<Event>();    

        static Data()
        {
            
            data.Add(new Event(1,"event1",new DateTime(2024,9,21)));
            data.Add(new Event(2,"event2",new DateTime(2024,9,22)));
            data.Add(new Event(3,"event3",new DateTime(2024,9,23)));
            data.Add(new Event(4,"event4",new DateTime(2024,9,24)));
            data.Add(new Event(5,"event5",new DateTime()));
        }
        public List<Event> GetAll()
        {
            return data;
        }
        public Event GetById(int id)
        {
            if(data==null) return null;
            return data.Where(p => p.Id == id).FirstOrDefault<Event>();
            // return data.Find(p=>p.Equals(id));
        }
        public void Post(Event e)
        {
            e.Id = data.Count+1;
            data.Add(e);
        }
       
        public void Put(int id, Event e)
        {
            if (data == null) { return; };
            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i].Id == id)
                {
                    data[i] = e;
                    return ;
                }
            }
            //return false;
        }
        public void Delete(int id)
        {
            data.Remove(GetById(id));
        }
    }
}
