using WebApplication1.DTO;

namespace WebApplication1.Service
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
                if (emp.UserId == id)
                    return emp;
            }
            return null;
        }

        public bool UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (emp.UserId == employees[i].UserId)
                {
                    employees[i] = emp;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            return employees.Remove(new Employee(id));
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public bool ChangeStatus(int id)
        {
            Employee emp=employees.Find(emp => emp.UserId == id);
            if (emp != null)
            {
                emp.EmployeeStatus = EStatus.employed;
                return true;
            }
            return false;
        }
    }
}
