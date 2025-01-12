using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eployment__agency.Data.Repositories
{
    public class RegionRepository : IRepository<Region>
    {

        protected DataContext _dataContext;

        public RegionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Region> GetAll()
        {
            return _dataContext.Regions.ToList();
        }

        public Region? GetById(int id)
        {
            return _dataContext.Regions.Find(id);
        }


        public Region Add(Region region)
        {
            _dataContext.Regions.Add(region);
            _dataContext.SaveChanges();
            return region;
        }

        public Region Update(Region region)
        {
            _dataContext.Regions.Update(region);
            _dataContext.SaveChanges();
            return region;
        }

        public void Delete(Region region)
        {
            _dataContext.Regions.Remove(region);
            _dataContext.SaveChanges();
        }

    }

}

