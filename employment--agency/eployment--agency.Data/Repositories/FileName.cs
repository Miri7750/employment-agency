using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eployment__agency.Data.Repositories
{
    public class JubRepository : IRepository<Jub>
    {

        protected DataContext _dataContext;

        public JubRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Jub> GetAll()
        {
            return _dataContext.Jubs.ToList();
        }

        public Jub? GetById(int id)
        {
            return _dataContext.Jubs.Find(id);
        }


        public Jub Add(Jub jub)
        {
            _dataContext.Jubs.Add(jub);
            _dataContext.SaveChanges();
            return jub;
        }

        public Jub Update(Jub jub)
        {
            _dataContext.Jubs.Update(jub);
            _dataContext.SaveChanges();
            return jub;
        }

        public void Delete(Jub jub)
        {
            _dataContext.Jubs.Remove(jub);
            _dataContext.SaveChanges();
        }

    }

}

