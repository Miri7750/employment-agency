using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class JubService
    {
        static List<Jub> jubList = new List<Jub>();
        static int id = 1;
        public void AddJub(Jub jub)
        {
            jub.JubId = id++;
            jubList.Add(jub);

        }
        public bool Update(int id,Jub jub)
        {
            for (int i = 0; i < jubList.Count; i++)
            {
                if (jubList[i].JubId == id)
                {
                    jubList[i].Region = jub.Region;
                    jubList[i].BusinessId = jub.BusinessId;
                    jubList[i].Name = jub.Name;
                    jubList[i].Created=jub.Created;
                    jubList[i].Description = jub.Description;
                    jubList[i].AdditionalRequirements = jub.AdditionalRequirements;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            for (int i = 0; i < jubList.Count; i++)
            {
                if (jubList[i].JubId == id)
                {
                    jubList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Jub> GetJubs()
        {


            return jubList;
        }

        public Jub GetJubById(int jubId)
        {
            for (int i = 0; i < jubList.Count; i++)
            {
                if (jubList[i].JubId == jubId)
                {

                    return jubList[i];
                }
            }
            return null;
        }

        public List<Jub> GetJubsByRegion(Region region)
        {
            return jubList.FindAll(jub => jub.Region == region);
        }
    }
}
