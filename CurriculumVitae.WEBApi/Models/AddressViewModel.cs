namespace CurriculumVitae.WEBApi.Models
{
    public class AddressViewModel : EntityViewModel
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int ProfileId { get; set; }
        public AddressViewModel()
        {
                
        }

    }
}
