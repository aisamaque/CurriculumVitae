namespace CurriculumVitae.WEBApi.Models
{
    public class EducationViewModel : EntityViewModel
    {
        public string University { get; set; }
        public string Years { get { return string.Format("{0} - {1}", StartYear, EndYear); } set { } }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int ProfileId { get; set; }

        public EducationViewModel(int id, string name, string university, string years)
        {
            Id = id;
            Name = name;
            University = university;
            Years = years;
        }

        public EducationViewModel()
        {

        }
    }
}
