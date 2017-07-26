using CurriculumVitae.DomainStandard.Interfaces.Application;
using CurriculumVitae.DomainStandard.Interfaces.Service;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.ApplicationStandard
{
    public class ProfileApplication : Application<Profile>, IProfileApplication
    {
        private readonly IProfileServices _application;

        public ProfileApplication(IProfileServices application)
            : base(application)
        {
            _application = application;
        }
    }
}
