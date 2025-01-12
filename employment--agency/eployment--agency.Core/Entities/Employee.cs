namespace eployment__agency.Core.Entities
{
    public enum EStatus
    {
        unemployed,
        employed
    }
    public class Employee
    {
        private static int nextId = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phon { get; set; }
        public string Adress { get; set; }
        public Jub? PrevJub { get; set; }
        public DateOnly RegistrationDate { get; set; }

        public List<Region> Regions { get; set; }
        public EStatus EmployeeStatus { get; set; }

        

        public Employee(string name, string phon, string adress, Jub? prevJub, DateOnly registrationDate, List<Region> regions, EStatus employeeStatus)
        {
            Id = nextId;
            nextId++;
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
            Id = userId;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id //&&
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
