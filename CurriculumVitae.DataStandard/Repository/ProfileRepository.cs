using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;
using System.Collections.Generic;

namespace CurriculumVitae.DataStandard.Repository
{
    public class ProfileRepository : RespositoryBase<Profile>, IProfileRepository
    {
        public ProfileRepository(CurriculumVitaeContext context) : base(context)
        {
        }
        public override Profile GetRelated(Profile obj)
        {
            Profile p = obj;
            if (p != null)
            {
                p.Address = (ICollection<Address>)new AddressRepository(Db).Find(x => x.ProfileId == p.Id);
                p.CareerProfile = (ICollection<Career>)new CareerRepository(Db).Find(x => x.ProfileId == p.Id);
                p.Contacts = (ICollection<Contact>)new ContactRepository(Db).Find(x => x.ProfileId == p.Id);
                p.Educations = (ICollection<Education>)new EducationRepository(Db).Find(x => x.ProfileId == p.Id);
                p.Interest = (ICollection<Interest>)new InterestRepository(Db).Find(x => x.ProfileId == p.Id);
                p.Languages = (ICollection<Language>)new LanguagesRepository(Db).Find(x => x.ProfileId == p.Id);
            }
            return p;
        }
    }
}
