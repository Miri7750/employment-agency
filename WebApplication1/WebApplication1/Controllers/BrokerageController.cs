using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerageController : ControllerBase
    {
        readonly BrokeragesService brokerageService = new BrokeragesService();
        // GET: api/<BrokerageController>
        [HttpGet]
        public ActionResult<List<Brokerage>> Get()
        {
            List<Brokerage> broks = brokerageService.GetBrokerages();
            if (broks == null)
                return new List<Brokerage>();
            return broks;
        }


        // GET api/<BrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Brokerage> Get(int id)
        {
            if(id <=0) return BadRequest();
            return brokerageService.GetBrokerageById(id);
        }

        // POST api/<BrokerageController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Brokerage value)
        {
            if (value == null)
                return BadRequest();
            brokerageService.Add(value);
            return true;
        }


        // PUT api/<BrokerageController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Brokerage value)
        {
            if (value == null || id <= 0)
                return BadRequest();
            if (brokerageService.Update(id, value))
                return true;
            return NotFound();
        }




        // DELETE api/<BrokerageController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            if (brokerageService.Delete(id))
                return true;
            return NotFound();
        }
    }
}
