namespace eployment__agency.Core.Entities
{
    public enum ECity
    {

    }
    public class Business
    {
        private static int nextId = 1;

        public int Id { get;  }
        public string Name { get; set; }

        public ECity City { get; set; }
        public Region Region { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
        public string ContactPerson { get; set; }
        public string PaymentDetails { get; set; }
        public string AuthorizedDealerNumber { get; set; }

        public Business( string name, ECity city, Region region, string email, string phone, string manager, string contactPerson, string paymentDetails, string authorizedDealerNumber)
        {
            Id = nextId;
            nextId++;
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
