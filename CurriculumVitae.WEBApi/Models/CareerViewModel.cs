using System.Collections.Generic;

namespace CurriculumVitae.WEBApi.Models
{
    public class CareerViewModel : EntityViewModel
    {
        public string Summary { get; set; }
        public List<ExperienceViewModel> Experiences { get; set; }
        public List<ProjectViewModel> Projects { get; set; }
        public List<SkillViewModel> Skills { get; set; }

        public int ProfileId { get; set; }
        public CareerViewModel()
        {
            Experiences = new List<ExperienceViewModel>();
            Projects = new List<ProjectViewModel>();
            Skills = new List<SkillViewModel>();
        }

    }
}
