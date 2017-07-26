using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumVitae.DomainStandard.Models
{
    public class ExperienceDetail : GenericDetail
    {

        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }

        public ExperienceDetail()
        {

        }
    }
}
