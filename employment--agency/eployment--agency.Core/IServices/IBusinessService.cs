using eployment__agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IServices
{
    public interface IBusinessService
    {
        List<Business> GetBusinesses();
        Business? GetBusiness(int id);
        Business AddBusiness(Business business);
        Business UpdateBusiness(int id,Business business);
        bool DeleteBusiness(int id);
    }
}
