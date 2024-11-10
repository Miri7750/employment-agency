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
            return bus;
        }

        // GET api/<BusinessController>/5
        [HttpGet("{id}")]
        public ActionResult< Business> Get(int id)
        {
            if(id <=0)return BadRequest();
            Business bus=businessService.GetBusinessById(id);
            if (bus != null)
                return bus;
            return NotFound();

        }

        // POST api/<BusinessController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Business business)
        {
            if(business == null)
                return BadRequest();
            
            businessService.AddBusiness(business);
                return true;
            

        }

        // PUT api/<BusinessController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Business value)
        {
            if(value == null || id <= 0)
                return BadRequest();
            if(businessService.UpdateBusiness(id, value))
                return true;
            return NotFound();
        }

        // DELETE api/<BusinessController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if(id <= 0)
                return BadRequest();
            if(businessService.DeleteBusiness(id))
                return true;
            return NotFound();
        }
    }
}
