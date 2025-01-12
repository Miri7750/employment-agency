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
    public class JubService : IJubService
    {
        private readonly IRepository<Jub> _jubRepository;
        public JubService(IRepository<Jub> jubRepository)
        {
            _jubRepository = jubRepository;
        }

        public Jub AddJub(Jub jub)
        {
            return _jubRepository.Add(jub);
        }

        public bool DeleteJub(int id)
        {
            Jub? jub = _jubRepository.GetById(id);
            if (jub != null)
            {
                _jubRepository.Delete(jub);
                return true;
            }
            return false;
        }

        public Jub? GetJub(int id)
        {
            return _jubRepository.GetById(id);
        }

        public List<Jub> GetJubs()
        {
            return _jubRepository.GetAll();
        }

        public Jub UpdateJub(int id, Jub jub)
        {
            return _jubRepository.Update(jub);
        }
    }
}

