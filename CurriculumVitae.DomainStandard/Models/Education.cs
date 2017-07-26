namespace CurriculumVitae.DomainStandard.Models
{
    public class Education : Entity
    {
        public string University { get; set; }
        public string Years { get { return string.Format("{0} - {1}", StartYear, EndYear); } set { } }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public Education(int id, string name, string university, string years)
        {
            Id = id;
            Name = name;
            University = university;
            Years = years;
        }

        public Education()
        {

        }
    }
}
