using eployment__agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IServices
{
    public interface IBrokerageService
    {
        List<Brokerage> GetBrokerages();
        Brokerage? GetBrokerage(int id);
        Brokerage AddBrokerage(Brokerage brokerage);
        bool DeleteBrokerage(int id);
        Brokerage UpdateBrokerage(int id,Brokerage brokerage);
    }
}
