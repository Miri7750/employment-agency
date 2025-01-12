namespace eployment__agency.Core.Entities
{
    public class Jub
    {
        private static int nextId = 1;

        public int JubId { get;  }
        public string Name { get; set; }
        public Region Region { get; set; }
        public string Description { get; set; }
        public string AdditionalRequirements { get; set; }  
        public DateTime Created { get; set; }
        public int BusinessId { get; set; }

        public Jub( string name, Region region, string description, string additionalRequirements, DateTime created, int businessId)
        {
            JubId = nextId;
            nextId++;
            Name = name;
            Region = region;
            Description = description;
            AdditionalRequirements = additionalRequirements;
            Created = created;
            BusinessId = businessId;
        }
    }
}
