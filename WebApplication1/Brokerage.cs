namespace WebApplication1.DTO
{
    public class Brokerage
    {
        public int BrokerageId { get; set; }
        public int EmployeeId {  get; set; }
        public int JubId { get; set; }
        public DateTime BrokerageDate { get; set; }
        public int BrokerageStatus { get; set; }
        public double BrokerageFees { get; set; }

        public Brokerage(int brokerageId, int employeeId, int jubId, DateTime brokerageDate, int brokerageStatus, double brokerageFees)
        {
            BrokerageId = brokerageId;
            EmployeeId = employeeId;
            JubId = jubId;
            BrokerageDate = brokerageDate;
            BrokerageStatus = brokerageStatus;
            BrokerageFees = brokerageFees;
        }

        public Brokerage()
        {
            
        }
        
    }
}
