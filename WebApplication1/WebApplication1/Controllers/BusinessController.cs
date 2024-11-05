using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly BusinessService businessService=new BusinessService();

        // GET: api/<BusinessController>
        [HttpGet]
        public ActionResult<List<Business>> Get()
        {
            List<Business> bus = businessService.GetAllBusinesses();
            if(bus == null)
                return NotFound();
            return Ok(bus);
        }

        // GET api/<BusinessController>/5
        [HttpGet("{id}")]
        public ActionResult< Business> Get(int id)
        {
            Business bus=businessService.GetBusinessById(id);
            if (bus != null)
                return Ok(bus);
            return NotFound();

        }

        // POST api/<BusinessController>
        [HttpPost]
        public ActionResult Post([FromBody] Business business)
        {
            if(business == null)
                return BadRequest();
            
            businessService.AddBusiness(business);
                return Ok();
            

        }

        // PUT api/<BusinessController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Business value)
        {
            if(value == null)
                return BadRequest();
            if(businessService.UpdateBusiness(value))
                return Ok();
            return NotFound();
        }

        // DELETE api/<BusinessController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(businessService.DeleteBusiness(id))
                return Ok();
            return NotFound();
        }
    }
}
