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
    public class BusinessService:IBusinessService
    {
        private readonly IRepository<Business> _businessRepository;
        public BusinessService(IRepository<Business> businessRepository)
        {
            _businessRepository = businessRepository;
        }

        public Business AddBusiness(Business business)
        {
            return _businessRepository.Add(business);
        }

        public bool DeleteBusiness(int id)
        {
            Business? business=_businessRepository.GetById(id);
            if (business != null)
            {
                _businessRepository.Delete(business);
                return true;
            }
            return false;
        }

        public Business? GetBusiness(int id)
        {
            return _businessRepository.GetById(id);
        }

        public List<Business> GetBusinesses()
        {
            return _businessRepository.GetAll();
        }

        public Business UpdateBusiness(int id, Business business)
        {
            return _businessRepository.Update(business);
        }
    }
}
