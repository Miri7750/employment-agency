using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class BusinessService
    {
        static List<Business> BusinessesList {  get; }=new List<Business>();

        public List<Business> GetAllBusinesses()
        {
            return BusinessesList;
        }
        public Business GetBusinessById(int id)
        {
            for (int i = 0; i < BusinessesList.Count; i++)
            {
                if (BusinessesList[i].BusinessId==id)
                    return BusinessesList[i];
            }
            return null;
        }

        public bool UpdateBusiness(Business business)
        {
            for(int i = 0;i < BusinessesList.Count;i++)
            {
                if (BusinessesList[i].BusinessId == business.BusinessId)
                {
                    BusinessesList[i] = business;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteBusiness(int id)
        {
            for (int i = 0; i < BusinessesList.Count; i++)
            {
                if (BusinessesList[i].BusinessId == id)
                {
                    BusinessesList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void AddBusiness(Business business)
        {
            business.BusinessId = BusinessesList[BusinessesList.Count-1].BusinessId+1;
            BusinessesList.Add(business);
        }

    }
}
