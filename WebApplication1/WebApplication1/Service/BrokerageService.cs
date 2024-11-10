

using Microsoft.AspNetCore.SignalR;
using WebApplication1.DTO;
namespace WebApplication1.Service
{
    public class BrokeragesService
    {
        static List<Brokerage> brokList = new List<Brokerage>();
        static int id = 1;
        public void Add(Brokerage brok)
        {
            brok.BrokerageId = id++;
            brokList.Add(brok);

        }
        public bool Update(int id,Brokerage brok)
        {
            for (int i = 0; i < brokList.Count; i++)
            {
                if (brokList[i].BrokerageId == id)
                {
                    brokList[i].BrokerageDate = brok.BrokerageDate;
                    brokList[i].BrokerageFees = brok.BrokerageFees;
                    brokList[i].BrokerageStatus = brok.BrokerageStatus;
                    brokList[i].BrokerageStatus=brok.BrokerageStatus;
                    brokList[i].JubId = brok.JubId;
                    brokList[i].EmployeeId = brok.EmployeeId;
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
