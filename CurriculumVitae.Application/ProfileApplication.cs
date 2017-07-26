using CurriculumVitae.Domain.Interfaces.Application;
using CurriculumVitae.Domain.Interfaces.Service;
using CurriculumVitae.Domain.Models;

namespace CurriculumVitae.Application
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
