using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using eployment__agency.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee AddEmployee(Employee employee)
        {
            return _employeeRepository.Add(employee);
        }

        public bool DeleteEmployee(int id)
        {
            Employee? employee = _employeeRepository.GetById(id);
            if (employee != null)
            {
                _employeeRepository.Delete(employee); 
                return true;
            }
            return false;
        }

        public Employee? GetEmployee(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            return _employeeRepository.Update(employee);
        }
    }
}
