namespace CurriculumVitae.WEBApi.Models
{
    public class LanguageViewModel : EntityViewModel
    {
        public string Level { get; set; }
        public int ProfileId { get; set; }
        public LanguageViewModel(int id, string name, string level)
        {
            Id = id;
            Name = name;
            Level = level;
        }
        public LanguageViewModel()
        {

        }

    }
}
