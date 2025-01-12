using eployment__agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IServices
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);
    }
}
