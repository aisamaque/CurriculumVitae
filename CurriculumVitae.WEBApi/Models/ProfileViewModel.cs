using System.Collections.Generic;

namespace CurriculumVitae.WEBApi.Models
{
    public class ProfileViewModel : EntityViewModel
    {
        public string Tagline { get; set; }
        public string ProfileURL { get; set; }
        public List<ContactViewModel> Contacts { get; set; }
        public List<EducationViewModel> Educations { get; set; }
        public List<LanguageViewModel> Languages { get; set; }
        public List<InterestViewModel> Interest { get; set; }
        public List<CareerViewModel>  CareerProfile { get; set; }
        public List<AddressViewModel>   Address { get; set; }

        public ProfileViewModel()
        {
            Address = new List<AddressViewModel>();
            CareerProfile = new List<CareerViewModel>();
            Contacts = new List<ContactViewModel>();
            Educations = new List<EducationViewModel>();
            Languages = new List<LanguageViewModel>();
            Interest = new List<InterestViewModel>();
        }
    }
}
