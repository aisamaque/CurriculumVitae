using System.Collections.Generic;

namespace CurriculumVitae.DomainStandard.Models
{
    public class Profile : Entity
    {
        public string Tagline { get; set; }
        public string ProfileURL { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Interest> Interest { get; set; }
        public virtual ICollection<Career>  CareerProfile { get; set; }
        public virtual ICollection<Address>   Address { get; set; }

        public Profile(int id,string name, string tagline,string profileurl)
        {
            Id = id;
            Name = name;
            Tagline = tagline;
            ProfileURL = profileurl;
        }

        public Profile()
        {
            Address = new List<Address>(); 
            CareerProfile = new List<Career>();
            Contacts = new List<Contact>();
            Educations = new List<Education>();
            Languages = new List<Language>();
            Interest = new List<Interest>();
        }
    }
}
