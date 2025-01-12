using eployment__agency.Core.Entities;
using eployment__agency.Core.IServices;
using eployment__agency.Service.Services;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eployment__agency.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerageController : ControllerBase
    {
        private readonly IBrokerageService _brokerageService ;

        public BrokerageController(BrokerageService brokerageService)
        {
            this._brokerageService = brokerageService;
        }


        // GET: api/<BrokerageController>
        [HttpGet]
        public ActionResult<List<Brokerage>> Get()
        {
            List<Brokerage> broks = _brokerageService.GetBrokerages();
            if (broks == null)
                return new List<Brokerage>();
            return broks;
        }


        // GET api/<BrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Brokerage> Get(int id)
        {
            if(id <=0) return BadRequest();
            return _brokerageService.GetBrokerage(id);
        }

        // POST api/<BrokerageController>
        [HttpPost]
        public ActionResult<Brokerage> Post([FromBody] Brokerage value)
        {
            if (value == null)
                return BadRequest();
            Brokerage res = _brokerageService.AddBrokerage( value);
            if (res == null)
                return BadRequest();
            return Ok(res);
        }


        // PUT api/<BrokerageController>/5
        [HttpPut("{id}")]
        public ActionResult<Brokerage> Put(int id, [FromBody] Brokerage value)
        {
            if (value == null || id <= 0)
                return BadRequest();
            Brokerage res= _brokerageService.UpdateBrokerage(id, value);
            if (res==null)
                return BadRequest();
            return Ok(res);
        }




        // DELETE api/<BrokerageController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            if (_brokerageService.DeleteBrokerage(id))
                return true;
            return BadRequest();
        }
    }
}
