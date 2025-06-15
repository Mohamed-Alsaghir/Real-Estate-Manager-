namespace Ass5DAL
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}, {ZipCode}, {Country}";
        }
    }

}
