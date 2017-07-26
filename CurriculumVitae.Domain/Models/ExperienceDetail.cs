using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Domain.Models
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
