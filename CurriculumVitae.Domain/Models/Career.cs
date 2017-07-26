using System.Collections.Generic;

namespace CurriculumVitae.Domain.Models
{
    public class Career : Entity
    {
        public string Summary { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public Career()
        {
            Experiences = new List<Experience>();
            Projects = new List<Project>();
            Skills = new List<Skill>();
        }


        public Career(int id, string name, string summary, ICollection<Experience> experiences, ICollection<Project> projects, ICollection<Skill> skills)
        {
            Id = id;
            Name = name;
            Summary = summary;
            Experiences = experiences;
            Projects = projects;
            Skills = skills;
        }
    }
}
