namespace CurriculumVitae.WEBApi.Models
{
    public class ContactViewModel : EntityViewModel
    {
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Value { get; set; }
        public int ProfileId { get; set; }

        public ContactViewModel(int id, string name, string type, string icon, string value)
        {
            Id = id;
            Name = name;
            Type = type;
            Icon = icon;
            Value = value;
        }

        public ContactViewModel()
        {

        }
    }
}
