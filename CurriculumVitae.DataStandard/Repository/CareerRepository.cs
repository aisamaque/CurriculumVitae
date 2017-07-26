using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;
using System.Collections.Generic;

namespace CurriculumVitae.DataStandard.Repository
{
    public class CareerRepository : RespositoryBase<Career>, ICareerRepository
    {
        public CareerRepository(CurriculumVitaeContext db) : base(db)
        { 
        }

        public override Career GetRelated(Career obj)
        {
            if (obj != null)
            {
                obj.Experiences = (ICollection<Experience>)new ExperienceRepository(Db).Find(x => x.CareerId == obj.Id);
                obj.Projects = (ICollection<Project>)new ProjectRepository(Db).Find(x => x.CareerId == obj.Id);
                obj.Skills = (ICollection<Skill>)new SkillRepository(Db).Find(x => x.CareerId == obj.Id);
            }
            return obj;
        }

    }
}