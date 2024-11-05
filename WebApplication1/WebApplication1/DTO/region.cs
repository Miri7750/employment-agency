namespace WebApplication1.DTO
{
    public class Region
    {
        public int RegionId { get; set; }
        public string Name { get; set; }
        public List<string> Requirements { get; set; }
        public Region Parent { get; set; }

        public Region(int regionId, string name, List<string> requirements, Region parent)
        {
            RegionId = regionId;
            Name = name;
            Requirements = requirements;
            Parent = parent;
        }
    }
}
