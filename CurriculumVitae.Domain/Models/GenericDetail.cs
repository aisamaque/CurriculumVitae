namespace CurriculumVitae.Domain.Models
{
    public class GenericDetail : Entity
    {
        public string Value { get; set; }

        public GenericDetail()
        {

        }
        public GenericDetail(int id, string name, string value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
