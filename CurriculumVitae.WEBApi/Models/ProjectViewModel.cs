namespace CurriculumVitae.WEBApi.Models
{
    public class ProjectViewModel : EntityViewModel
    {
        public string ProjectUrl { get; set; }
        public string Value { get; set; }
        public int CareerId { get; set; }
        public ProjectViewModel(int id, string name, string projecturl, string value)
        {
            Id = id;
            Name = name;
            ProjectUrl = projecturl;
            Value = value;
        }

        public ProjectViewModel()
        {

        }
    }
}
