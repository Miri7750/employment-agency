namespace eployment__agency.Core.Entities
{
    public class Region
    {
        private static int nextId = 1;

        public int RegionId { get; }
        public string Name { get; set; }
        public List<string> Requirements { get; set; }
        public Region Parent { get; set; }

        public Region( string name, List<string> requirements, Region parent)
        {
            RegionId = nextId;
            nextId++;
            Name = name;
            Requirements = requirements;
            Parent = parent;
        }
    }
}
