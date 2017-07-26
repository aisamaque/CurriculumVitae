namespace CurriculumVitae.Domain.Models
{
    public class Interest : Entity
    {
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public Interest(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Interest()
        {
                
        }
    }
}
