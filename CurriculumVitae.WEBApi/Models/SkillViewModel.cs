namespace CurriculumVitae.WEBApi.Models
{
    public class SkillViewModel : EntityViewModel
    {
        public int Level { get; set; }
        public int CareerId { get; set; }
        public SkillViewModel(int id, string name, int level)

        {
            Id = id;
            Name = name;
            Level = level;
        }

        public SkillViewModel()
        {

        }
    }
}
