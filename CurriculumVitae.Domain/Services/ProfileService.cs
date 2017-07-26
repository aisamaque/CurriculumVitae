using CurriculumVitae.Domain.Interfaces.Repository;
using CurriculumVitae.Domain.Interfaces.Service;
using CurriculumVitae.Domain.Models;

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
