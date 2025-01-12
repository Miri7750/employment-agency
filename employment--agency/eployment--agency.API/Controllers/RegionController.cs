using eployment__agency.Core.Entities;
using eployment__agency.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eployment__agency.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        readonly IRegionService _regionsService ;
        public RegionController(IRegionService regionService)
        {
            _regionsService = regionService;
        }
        // GET: api/<RegionController>
        [HttpGet]
        public ActionResult<List<Region>> Get()
        {
            List<Region> regions = _regionsService.GetRegions();
            if (regions == null)
                return BadRequest();
            return regions;
        }

        // GET api/<RegionController>/5
        [HttpGet("{id}")]
        public ActionResult<Region> Get(int id)
        {
            if(id<0)return BadRequest();
            return _regionsService.GetRegion(id);
        }

        
        // POST api/<RegionController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Region value)
        {
            if (value == null)
                return BadRequest();
            _regionsService.AddRegion(value);
            return true;
        }

        // PUT api/<RegionController>/5
        [HttpPut("{id}")]
        public ActionResult<Region> Put(int id, [FromBody] Region value)
        {
            if (value == null||id<=0)
                return BadRequest();
            Region res = _regionsService.UpdateRegion(id, value);
            if (res!=null)
                return res;
            return BadRequest();
        }


        // DELETE api/<RegionController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (_regionsService.DeleteRegion(id))
                return true;
            return BadRequest();
        }
    }
}



