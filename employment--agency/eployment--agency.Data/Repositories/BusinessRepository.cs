using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eployment__agency.Data.Repositories
{
    public class BusinessRepository : IRepository<Business>
    {

        protected DataContext _dataContext;

        public BusinessRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Business> GetAll()
        {
            return _dataContext.Businesses.ToList();
        }

        public Business? GetById(int id)
        {
            return _dataContext.Businesses.Find(id);
        }


        public Business Add(Business business)
        {
            _dataContext.Businesses.Add(business);
            _dataContext.SaveChanges();
            return business;
        }

        public Business Update(Business business)
        {
            _dataContext.Businesses.Update(business);
            _dataContext.SaveChanges();
            return business;
        }

        public void Delete(Business business)
        {
            _dataContext.Businesses.Remove(business);
            _dataContext.SaveChanges();
        }

    }

}

