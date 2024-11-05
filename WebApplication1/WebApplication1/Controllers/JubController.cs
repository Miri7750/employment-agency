using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JubController : ControllerBase
    {
        readonly JubService jubsService= new JubService();

        // GET: api/<JubController>
        [HttpGet]
        public ActionResult<List<Jubs>> Get()
        {
            List<Jubs> jubs=jubsService.GetJubs();
            if (jubs==null)
                return NotFound();
            return Ok(jubs);
        }

        // GET api/<JubController>/5
        [HttpGet("{id}")]
        public ActionResult<Jubs> Get(int id)
        {
           return Ok( jubsService.GetJubById(id));
        }

        // GET api/<JubController>/reg
        [HttpGet("{region}")]
        public ActionResult<Jubs> Get(Region region)
        {
            return Ok(jubsService.GetJubsByRegion(region));
        }

        // POST api/<JubController>
        [HttpPost]
        public ActionResult Post([FromBody] Jubs value)
        {
            if (value == null)
                return BadRequest();
            jubsService.AddJub(value);
            return Ok();
        }

        // PUT api/<JubController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Jubs value)
        {
            if(value == null)
                return BadRequest();
            if(jubsService.Update(value))
                return Ok();
            return NotFound();
        }


        // DELETE api/<JubController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(jubsService.Delete(id))
                return Ok();
            return NotFound();
        }
    }
}
