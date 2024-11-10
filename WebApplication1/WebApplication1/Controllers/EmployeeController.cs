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
            return empList;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            if (id <= 0) return BadRequest();
            Employee emp= employeeService.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return emp; 
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee value)
        {
            if (value == null)
                return BadRequest();
            employeeService.AddEmployee(value);
            return true;

        }   
            

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Employee value)
        {
            if(value == null || id <= 0)
                return BadRequest();
            if (employeeService.UpdateEmployee(id, value))
                return true;
            return NotFound();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool>    Delete(int id)
        {
            if(id <=0)
                return BadRequest();
            if(employeeService.DeleteEmployee(id))
                return true;
            return NotFound();

        }
    }
}
