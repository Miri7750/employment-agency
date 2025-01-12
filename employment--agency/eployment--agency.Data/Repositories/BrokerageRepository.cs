using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eployment__agency.Data.Repositories
{
    public class BrokerageRepository : IRepository<Brokerage>
    {

        protected DataContext _dataContext;

        public BrokerageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Brokerage> GetAll()
        {
            return _dataContext.Brokerages.ToList();
        }

        public Brokerage? GetById(int id)
        {
            return _dataContext.Brokerages.Find(id);
        }


        public Brokerage Add(Brokerage brokerage)
        {
            _dataContext.Brokerages.Add(brokerage);
            _dataContext.SaveChanges();
            return brokerage;
        }

        public Brokerage Update(Brokerage brokerage)
        {
            _dataContext.Brokerages.Update(brokerage);
            _dataContext.SaveChanges();
            return brokerage;
        }

        public void Delete(Brokerage brokerage)
        {
            _dataContext.Brokerages.Remove(brokerage);
            _dataContext.SaveChanges();
        }

    }

}
