using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class InterestRepository : RespositoryBase<Interest>, IInterestRepository
    {
        public InterestRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}