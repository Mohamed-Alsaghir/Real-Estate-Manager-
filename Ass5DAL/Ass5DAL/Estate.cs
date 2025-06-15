
using System.ComponentModel;

namespace Ass5DAL
{
    public class Estate
    {
        public int EstateId { get; set; }
        public int AddressId { get; set; }
        public string Category { get; set; }

        [Browsable(false)] // Hide the Address object in DataGridView
        public Address Address { get; set; }

        // Add these display properties for the DataGridView
        [DisplayName("Street")]
        public string Street => Address?.Street ?? "";

        [DisplayName("City")]
        public string City => Address?.City ?? "";

        [DisplayName("Zip Code")]
        public string ZipCode => Address?.ZipCode ?? "";

        [DisplayName("Country")]
        public string Country => Address?.Country ?? "";
    }


}
