using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class RegionService
    {
        static List<Region> regionList = new List<Region>();
        static int id = 1;
        public void AddRegion(Region region)
        {
            region.RegionId = id++;
            regionList.Add(region);

        }
        public bool Update(int id,Region region)
        {
            for (int i = 0; i < regionList.Count; i++)
            {
                if (regionList[i].RegionId == id)
                {
                    regionList[i].Requirements = region.Requirements;
                    regionList[i].Name = region.Name;
                    regionList[i].Parent = region.Parent;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            for (int i = 0; i < regionList.Count; i++)
            {
                if (regionList[i].RegionId == id)
                {
                    regionList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Region> GetRegions()
        {


            return regionList;
        }

        public Region GetRegionById(int regionId)
        {
            for (int i = 0; i < regionList.Count; i++)
            {
                if (regionList[i].RegionId == regionId)
                {

                    return regionList[i];
                }
            }
            return null;
        }

        
    }
}

