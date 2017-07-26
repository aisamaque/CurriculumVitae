using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Interfaces.Service;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.Domain.Services
{
    public class ProfileService : ServiceBase<Profile>, IProfileServices
    {
        private readonly IProfileRepository _repository;

        public ProfileService(IProfileRepository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
