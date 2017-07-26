using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;
using System.Collections.Generic;

namespace CurriculumVitae.DataStandard.Repository
{
    public class ExperienceRepository : RespositoryBase<Experience>, IExperienceRepository
    {
        public ExperienceRepository(CurriculumVitaeContext context) : base(context)
        {
        }

        public override Experience GetRelated(Experience obj)
        {
            if (obj != null)
            {
                obj.Details = (ICollection<ExperienceDetail>)new DetailRepository(Db).Find(x => x.ExperienceId == obj.Id);
            }

            return obj;
        }
    }
}