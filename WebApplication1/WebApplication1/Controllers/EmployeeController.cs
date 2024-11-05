using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly EmployeeService employeeService=new EmployeeService();
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            List<Employee> empList= employeeService.GetEmployees();
            if (empList == null)
            {
                return NotFound();
            }
            return Ok(empList);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee emp= employeeService.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp); 
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] Employee value)
        {
            if (value == null)
                return BadRequest();
            employeeService.AddEmployee(value);
            return Ok();

        }   
            

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee value)
        {
            if (employeeService.UpdateEmployee(value))
                return Ok();
            return NotFound();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(employeeService.DeleteEmployee(id))
                return Ok();
            return NotFound();

        }
    }
}
