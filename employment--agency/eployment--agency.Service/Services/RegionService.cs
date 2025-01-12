using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using eployment__agency.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Service.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> _regionRepository;
        public RegionService(IRepository<Region> regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public Region AddRegion(Region region)
        {
            return _regionRepository.Add(region);
        }

        public bool DeleteRegion(int id)
        {
            Region? region = _regionRepository.GetById(id);
            if (region != null)
            {
                _regionRepository.Delete(region);
                return true;
            }
            return false;
        }

        public Region? GetRegion(int id)
        {
            return _regionRepository.GetById(id);
        }

        public List<Region> GetRegions()
        {
            return _regionRepository.GetAll();
        }

        public Region UpdateRegion(int id, Region region)
        {
            return _regionRepository.Update(region);
        }
    }
}

