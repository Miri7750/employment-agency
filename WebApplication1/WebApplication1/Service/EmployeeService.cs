using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class EmployeeService
    {
        static List<Employee> employees = new List<Employee>();
        static int id = 1;
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

        public bool UpdateEmployee(int id,Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (emp.UserId == employees[i].UserId)
                {
                    employees[i].Adress = emp.Adress;
                    employees[i].Regions = emp.Regions;
                    employees[i].PrevJub= emp.PrevJub;
                    employees[i].EmployeeStatus = emp.EmployeeStatus;
                    employees[i].Name = emp.Name;
                    employees[i].Phon = emp.Phon;
                    employees[i].RegistrationDate = emp.RegistrationDate;

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
            emp.UserId = id++;
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
