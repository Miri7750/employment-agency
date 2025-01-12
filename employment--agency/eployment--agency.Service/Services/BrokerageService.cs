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
    public class BrokerageService:IBrokerageService
    {
        private readonly IRepository<Brokerage> _brokerageRepository;
        public BrokerageService(IRepository<Brokerage> brokerageRepository)
        {
            _brokerageRepository = brokerageRepository;
        }
        public Brokerage AddBrokerage(Brokerage brokerage)
        {
            return _brokerageRepository.Add(brokerage);
        }

        public bool DeleteBrokerage(int id)
        {
            Brokerage? brokerage=GetBrokerage(id);
            if (brokerage != null)
            {
                _brokerageRepository.Delete(id);
                return true;
            }
            return false;
        }

        public Brokerage? GetBrokerage(int id)
        {
            return _brokerageRepository.GetById(id);
        }

        public List<Brokerage> GetBrokerages()
        {
            return _brokerageRepository.GetAll();
        }

        public Brokerage UpdateBrokerage(int id, Brokerage brokerage)
        {
           return _brokerageRepository.Update(brokerage);
        }
    }
}
