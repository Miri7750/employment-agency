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
                return NotFound();
            return Ok(broks);
        }


        // GET api/<BrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Jubs> Get(int id)
        {
            return Ok(brokerageService.GetBrokerageById(id));
        }

        // POST api/<BrokerageController>
        [HttpPost]
        public ActionResult Post([FromBody] Brokerage value)
        {
            if (value == null)
                return BadRequest();
            brokerageService.Add(value);
            return Ok();
        }


        // PUT api/<BrokerageController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Brokerage value)
        {
            if (value == null)
                return BadRequest();
            if (brokerageService.Update(value))
                return Ok();
            return NotFound();
        }




        // DELETE api/<BrokerageController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (brokerageService.Delete(id))
                return Ok();
            return NotFound();
        }
    }
}
