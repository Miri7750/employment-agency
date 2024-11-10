using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        readonly RegionService regionsService = new RegionService();

        // GET: api/<RegionController>
        [HttpGet]
        public ActionResult<List<Region>> Get()
        {
            List<Region> regions = regionsService.GetRegions();
            if (regions == null)
                return NotFound();
            return regions;
        }

        // GET api/<RegionController>/5
        [HttpGet("{id}")]
        public ActionResult<Region> Get(int id)
        {
            if(id<0)return BadRequest();
            return regionsService.GetRegionById(id);
        }

        
        // POST api/<RegionController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Region value)
        {
            if (value == null)
                return BadRequest();
            regionsService.AddRegion(value);
            return true;
        }

        // PUT api/<RegionController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Region value)
        {
            if (value == null||id<=0)
                return BadRequest();
            if (regionsService.Update(id, value))
                return true;
            return NotFound();
        }


        // DELETE api/<RegionController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (regionsService.Delete(id))
                return true;
            return NotFound();
        }
    }
}



