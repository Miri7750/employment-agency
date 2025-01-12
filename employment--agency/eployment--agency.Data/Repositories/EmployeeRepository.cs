using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eployment__agency.Data.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {

        protected DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Employee> GetAll()
        {
            return _dataContext.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            return _dataContext.Employees.Find(id);
        }


        public Employee Add(Employee employee)
        {
            _dataContext.Employees.Add(employee);
            _dataContext.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employee)
        {
            _dataContext.Employees.Update(employee);
            _dataContext.SaveChanges();
            return employee;
        }

        public void Delete(Employee employee)
        {
            _dataContext.Employees.Remove(employee);
            _dataContext.SaveChanges();
        }

    }

}

