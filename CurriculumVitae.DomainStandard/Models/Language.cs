namespace CurriculumVitae.DomainStandard.Models
{
    public class Language : Entity
    {
        public string Level { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public Language(int id, string name, string level)
        {
            Id = id;
            Name = name;
            Level = level;
        }
        public Language()
        {

        }

    }
}
