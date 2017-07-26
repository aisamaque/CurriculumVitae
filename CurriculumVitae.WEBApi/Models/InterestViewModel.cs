namespace CurriculumVitae.WEBApi.Models
{
    public class InterestViewModel : EntityViewModel
    {
        public int ProfileId { get; set; }
        public InterestViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public InterestViewModel()
        {
                
        }
    }
}
