namespace CurriculumVitae.Domain.Models
{
    public class Skill:Entity
    {
        public int Level { get; set; }
        public int CareerId { get; set; }
        public virtual Career Career { get; set; }
        public Skill(int id, string name, int level)

        {
            Id = id;
            Name = name;
            Level = level;
        }

        public Skill()
        {

        }
    }
}
