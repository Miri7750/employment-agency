using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class JubService
    {
        static List<Jubs> jubList = new List<Jubs>();

        public void AddJub(Jubs jub)
        {
            jubList.Add(jub);

        }
        public bool Update(Jubs jub)
        {
            for (int i = 0; i < jubList.Count; i++)
            {
                if (jubList[i].JubId == jub.JubId)
                {
                    jubList[i] = jub;
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

        public List<Jubs> GetJubs()
        {


            return jubList;
        }

        public Jubs GetJubById(int jubId)
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

        public List<Jubs> GetJubsByRegion(Region region)
        {
            return jubList.FindAll(jub => jub.Region == region);
        }
    }
}
