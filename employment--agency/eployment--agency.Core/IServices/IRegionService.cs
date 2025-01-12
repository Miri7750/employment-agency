using eployment__agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IServices
{
    public interface IRegionService
    {
        List<Region> GetRegions();
        Region? GetRegion(int id);
        Region AddRegion(Region region);
        Region UpdateRegion(int id, Region region);
        bool DeleteRegion(int id);
    }
}
