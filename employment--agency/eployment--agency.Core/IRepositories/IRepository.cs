using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IRepositories
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T? GetById(int id);
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
