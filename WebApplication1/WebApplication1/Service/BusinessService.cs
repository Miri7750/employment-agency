using WebApplication1.DTO;

namespace WebApplication1.Service
{
    public class BusinessService
    {
        static List<Business> BusinessesList {  get; }=new List<Business>();
        static int id=1;
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

        public bool UpdateBusiness(int id,Business business)
        {
            for(int i = 0;i < BusinessesList.Count;i++)
            {
                if (BusinessesList[i].BusinessId == id)
                {
                    BusinessesList[i].Region = business.Region;
                    BusinessesList[i].Name = business.Name;
                    BusinessesList[i].City = business.City;
                    BusinessesList[i].ContactPerson = business.ContactPerson;
                    BusinessesList[i].Manager = business.Manager;
                    BusinessesList[i].Email = business.Email;
                    BusinessesList[i].PaymentDetails = business.PaymentDetails;
                    BusinessesList[i].Phone = business.Phone;
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
            business.BusinessId = id++;
            BusinessesList.Add(business);
        }

    }
}
