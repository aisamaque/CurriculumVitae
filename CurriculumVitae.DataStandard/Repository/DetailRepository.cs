using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class DetailRepository : RespositoryBase<ExperienceDetail>, IDetailRepository
    {
        public DetailRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}