using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class EducationRepository : RespositoryBase<Education>, IEducationRepository
    {
        public EducationRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}