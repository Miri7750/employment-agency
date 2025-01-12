using eployment__agency.Core.Entities;
using eployment__agency.Core.IServices;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eployment__agency.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IBusinessService _businessService;

        public BusinessController(IBusinessService businessService)
        {
            _businessService = businessService;
        }


        // GET: api/<BusinessController>
        [HttpGet]
        public ActionResult<List<Business>> Get()
        {
            List<Business> bus = _businessService.GetBusinesses();
            if(bus == null)
                return BadRequest();
            return bus;
        }

        // GET api/<BusinessController>/5
        [HttpGet("{id}")]
        public ActionResult< Business> Get(int id)
        {
            
            Business bus=_businessService.GetBusiness(id);
            if (bus != null)
                return Ok(bus);
            return BadRequest();

        }

        // POST api/<BusinessController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Business business)
        {
            if(business == null)
                return BadRequest();
            
            _businessService.AddBusiness(business);
                return true;
            

        }

        // PUT api/<BusinessController>/5
        [HttpPut("{id}")]
        public ActionResult<Business> Put(int id, [FromBody] Business value)
        {
            if(value == null || id <= 0)
                return BadRequest();
            Business res = _businessService.UpdateBusiness(id, value);
            if (res==null)
                return BadRequest();
            return Ok(res);
        }

        // DELETE api/<BusinessController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if(id <= 0)
                return BadRequest();
            if(_businessService.DeleteBusiness(id))
                return true;
            return BadRequest();
        }
    }
}
