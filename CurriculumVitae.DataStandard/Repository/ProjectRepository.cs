using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class ProjectRepository : RespositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}