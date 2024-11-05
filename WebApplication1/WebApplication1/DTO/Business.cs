using WebApplication1.DTO;

namespace WebApplication1.DTO
{
    public enum ECity
    {

    }
    public class Business
    {
        public int BusinessId { get; set; }
        public string Name { get; set; }

        public ECity City { get; set; }
        public Region Region { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
        public string ContactPerson { get; set; }
        public string PaymentDetails { get; set; }
        public string AuthorizedDealerNumber { get; set; }

        public Business(int businessId, string name, ECity city, Region region, string email, string phone, string manager, string contactPerson, string paymentDetails, string authorizedDealerNumber)
        {
            BusinessId = businessId;
            Name = name;
            City = city;
            Region = region;
            Email = email;
            Phone = phone;
            Manager = manager;
            ContactPerson = contactPerson;
            PaymentDetails = paymentDetails;
            AuthorizedDealerNumber = authorizedDealerNumber;
        }
    }
}
