namespace CurriculumVitae.DomainStandard.Models
{
    public class Contact : Entity
    {
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Value { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }

        public Contact(int id, string name, string type, string icon, string value)
        {
            Id = id;
            Name = name;
            Type = type;
            Icon = icon;
            Value = value;
        }

        public Contact()
        {

        }
    }
}
