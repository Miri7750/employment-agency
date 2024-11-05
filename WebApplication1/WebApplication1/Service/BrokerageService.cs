

using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;
namespace WebApplication1.Service
{
    public class BrokeragesService
    {
        static List<Brokerage> brokList = new List<Brokerage>();

        public void Add(Brokerage brok)
        {
            brokList.Add(brok);

        }
        public bool Update(Brokerage brok)
        {
            for (int i = 0; i < brokList.Count; i++)
            {
                if (brokList[i].BrokerageId == brok.BrokerageId)
                {
                    brokList[i] = brok;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            for (int i = 0; i < brokList.Count; i++)
            {
                if (brokList[i].BrokerageId == id)
                {
                    brokList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Brokerage> GetBrokerages()
        {


            return brokList;
        }

        public Brokerage GetBrokerageById(int Id)
        {
            for (int i = 0; i < brokList.Count; i++)
            {
                if (brokList[i].BrokerageId == Id)
                {

                    return brokList[i];
                }
            }
            return null;
        }

       
    }
}
