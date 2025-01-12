using eployment__agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eployment__agency.Core.IServices
{
    public interface IJubService
    {
        List<Jub> GetJubs();
        Jub? GetJub(int id);
        Jub AddJub(Jub jub);
        Jub UpdateJub(int id, Jub jub);
        bool DeleteJub(int id);
    }
}
