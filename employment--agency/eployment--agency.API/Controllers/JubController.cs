using eployment__agency.Core.Entities;
using eployment__agency.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eployment__agency.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JubController : ControllerBase
    {
        readonly IJubService _jubsService;

        public JubController(IJubService jubsService)
        {
            this._jubsService = jubsService;
        }

        // GET: api/<JubController>
        [HttpGet]
        public ActionResult<List<Jub>> Get()
        {
            List<Jub> jubs = _jubsService.GetJubs();
            if (jubs == null)
                return BadRequest();
            return jubs;
        }

        // GET api/<JubController>/5
        [HttpGet("{id}")]
        public ActionResult<Jub> Get(int id)
        {
            if (id <= 0) return BadRequest();
            return _jubsService.GetJub(id);
        }

        // GET api/<JubController>/reg
       // [HttpGet("{jub}")]
       // public ActionResult<List<Jub>> Get(Region region)
        //{
        //    return _jubsService.GetJubsByRegion(region);
        //}

        // POST api/<JubController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Jub value)
        {
            if (value == null)
                return BadRequest();
            _jubsService.AddJub(value);
            return true;
        }

        // PUT api/<JubController>/5
        [HttpPut("{id}")]
        public ActionResult<Jub> Put(int id, [FromBody] Jub value)
        {
            if (value == null || id <= 0)
                return BadRequest();
            Jub res = _jubsService.UpdateJub(id, value);
            if (res!=null)
                return res;
            return BadRequest();
        }


        // DELETE api/<JubController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            if (_jubsService.DeleteJub(id))
                return true;
            return BadRequest();
        }
    }
}


