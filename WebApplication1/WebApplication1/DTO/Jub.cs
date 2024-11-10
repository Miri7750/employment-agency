namespace WebApplication1.DTO
{
    public class Jub
    {
        public int JubId { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public string Description { get; set; }
        public string AdditionalRequirements { get; set; }  
        public DateTime Created { get; set; }
        public int BusinessId { get; set; }

        public Jub(int jubId, string name, Region region, string description, string additionalRequirements, DateTime created, int businessId)
        {
            JubId = jubId;
            Name = name;
            Region = region;
            Description = description;
            AdditionalRequirements = additionalRequirements;
            Created = created;
            BusinessId = businessId;
        }
    }
}
