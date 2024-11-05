namespace WebApplication1.DTO
{
    public enum EStatus
    {
        unemployed,
        employed
    }
    public class Employee
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phon { get; set; }
        public string Adress { get; set; }
        public Jubs? PrevJub { get; set; }
        public DateOnly RegistrationDate { get; set; }

        public List<Region> Regions { get; set; }
        public EStatus EmployeeStatus { get; set; }

        

        public Employee(int userId, string name, string phon, string adress, Jubs? prevJub, DateOnly registrationDate, List<Region> regions, EStatus employeeStatus)
        {
            UserId = userId;
            Name = name;
            Phon = phon;
            Adress = adress;
            PrevJub = prevJub;
            RegistrationDate = registrationDate;
            Regions = regions;
            EmployeeStatus = employeeStatus;
        }

        public Employee(int userId)
        {
            UserId = userId;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   UserId == employee.UserId //&&
                                             //Name == employee.Name &&
                                             //Phon == employee.Phon &&
                                             //Adress == employee.Adress &&
                                             //EqualityComparer<Jubs?>.Default.Equals(PrevJub, employee.PrevJub) &&
                                             //RegistrationDate.Equals(employee.RegistrationDate) &&
                                             //EqualityComparer<List<Region>>.Default.Equals(Regions, employee.Regions) &&
                                             //EmployeeStatus == employee.EmployeeStatus;
                   ;
        }
    }
}
