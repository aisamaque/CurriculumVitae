namespace CurriculumVitae.DomainStandard.Models
{
    public class Project:Entity
    {
        public string ProjectUrl { get; set; }
        public string Value { get; set; }
        public int CareerId { get; set; }
        public virtual Career Career { get; set; }
        public Project(int id, string name, string projecturl, string value)
        {
            Id = id;
            Name = name;
            ProjectUrl = projecturl;
            Value = value;
        }

        public Project()
        {

        }
    }
}
