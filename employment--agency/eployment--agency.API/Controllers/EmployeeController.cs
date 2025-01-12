using eployment__agency.Core.Entities;
using eployment__agency.Core.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eployment__agency.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            List<Employee> empList= _employeeService.GetEmployees();
            if (empList == null)
            {   
                return BadRequest();  
            }
            return empList;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            if (id <= 0) return BadRequest();
            Employee emp= _employeeService.GetEmployee(id);
            if (emp == null)
            {   
                return BadRequest();
            }
            return emp; 
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee value)
        {
            if (value == null)
                return BadRequest();
            _employeeService.AddEmployee(value);
            return true;

        }   
            

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee value)
        {
            if(value == null || id <= 0)
                return BadRequest();
            Employee res = _employeeService.UpdateEmployee(id, value);
            if (res!=null)
                return res;
            return BadRequest();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool>    Delete(int id)
        {
            if(id <=0)
                return BadRequest();
            if(_employeeService.DeleteEmployee(id))
                return true;
            return BadRequest();

        }
    }
}
