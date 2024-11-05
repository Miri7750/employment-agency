using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public Data EventList { get; set; }=new Data();
        // GET: api/<EventsController>
        [HttpGet]
        public List<Event> Get()
        {
           
            return EventList.GetAll();
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
             return EventList.GetById(id);
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event e)
        {
            EventList.Post(e);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event e)
        {
            EventList.Put(id, e);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            EventList.Delete(id);
        }
    }
}
