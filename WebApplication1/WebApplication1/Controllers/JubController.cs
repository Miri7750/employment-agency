using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JubController : ControllerBase
    {
        readonly JubService jubsService = new JubService();

        // GET: api/<JubController>
        [HttpGet]
        public ActionResult<List<Jub>> Get()
        {
            List<Jub> jubs = jubsService.GetJubs();
            if (jubs == null)
                return NotFound();
            return jubs;
        }

        // GET api/<JubController>/5
        [HttpGet("{id}")]
        public ActionResult<Jub> Get(int id)
        {
            if (id <= 0) return BadRequest();
            return jubsService.GetJubById(id);
        }

        // GET api/<JubController>/reg
        [HttpGet("{jub}")]
        public ActionResult<List<Jub>> Get(Region region)
        {
            return jubsService.GetJubsByRegion(region);
        }

        // POST api/<JubController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Jub value)
        {
            if (value == null)
                return BadRequest();
            jubsService.AddJub(value);
            return true;
        }

        // PUT api/<JubController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Jub value)
        {
            if (value == null || id <= 0)
                return BadRequest();
            if (jubsService.Update(id, value))
                return true;
            return NotFound();
        }


        // DELETE api/<JubController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            if (jubsService.Delete(id))
                return true;
            return NotFound();
        }
    }
}


