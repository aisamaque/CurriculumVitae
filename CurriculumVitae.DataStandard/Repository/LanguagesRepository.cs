using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class LanguagesRepository : RespositoryBase<Language>, ILanguageRepository
    {
        public LanguagesRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}