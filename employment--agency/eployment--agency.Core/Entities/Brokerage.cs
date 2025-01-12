namespace eployment__agency.Core.Entities
{
    public class Brokerage
    {
        private static int nextId = 1;

        public int Id { get; }
        public int EmployeeId { get; set; }
        public int JubId { get; set; }
        public DateTime BrokerageDate { get; set; }
        public int BrokerageStatus { get; set; }
        public double BrokerageFees { get; set; }

        public Brokerage( int employeeId, int jubId, DateTime brokerageDate, int brokerageStatus, double brokerageFees)
        {
            Id = nextId;
            nextId++;
            EmployeeId = employeeId;
            JubId = jubId;
            BrokerageDate = brokerageDate;
            BrokerageStatus = brokerageStatus;
            BrokerageFees = brokerageFees;
        }

        

    }
}
