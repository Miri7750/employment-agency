using WebApplication1.DTO;

namespace WebApplication1.Services
{
    public class EmployeeService
    {
        static List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if(emp.UserId == id)
                    return emp;
            }
            return null;
        }

        public void UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (emp.UserId == employees[i].UserId)
                    employees[i] = emp;
            }
        }

        public void DeleteEmployee(int id)
        {
            employees.Remove(new Employee( id));
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
