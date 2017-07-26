using System;
using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class SkillRepository : RespositoryBase<Skill>, ISkillRepository
    {
        public SkillRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}