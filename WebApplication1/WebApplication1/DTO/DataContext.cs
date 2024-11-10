namespace WebApplication1.DTO
{
    public class DataContext
    {
        public List<Employee> Employees { get; set; }=new List<Employee>();
        public List<Brokerage> Brokerages { get; set; } =new List<Brokerage>();
        public List<Business> Businesses { get; set; } = new List<Business>();
        public List<Jub>jubs { get; set; }= new List<Jub>();
        public List<Region> Regions { get; set; } = new List<Region>();

    }
}
