using System.Collections.Generic;

namespace CurriculumVitae.WEBApi.Models
{
    public class ExperienceViewModel : EntityViewModel
    {
        public string Period { get { return string.Format("{0} - {1}", StartYear, EndYear==0 ? "Atual" : EndYear.ToString()); } set {  } }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Company { get; set; }
        public List<ExperienceDetailViewModel> Details { get; set; }

        public int CareerId { get; set; }

        public ExperienceViewModel()
        {
            Details = new List<ExperienceDetailViewModel>();
        }

    }
}
