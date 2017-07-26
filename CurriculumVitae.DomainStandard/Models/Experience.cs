using System.Collections.Generic;

namespace CurriculumVitae.DomainStandard.Models
{
    public class Experience : Entity
    {
        public string Period { get { return string.Format("{0} - {1}", StartYear, EndYear==0 ? "Atual" : EndYear.ToString()); } set {  } }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Company { get; set; }
        public virtual ICollection<ExperienceDetail> Details { get; set; }

        public int CareerId { get; set; }
        public virtual Career Career { get; set; }
        public Experience(int id, string name, string period, string company, ICollection<ExperienceDetail> details)
        {
            Id = id;
            Name = name;
            Period = period;
            Company = company;
            Details = details;
        }

        public Experience()
        {
            Details = new List<ExperienceDetail>();
        }

    }
}
