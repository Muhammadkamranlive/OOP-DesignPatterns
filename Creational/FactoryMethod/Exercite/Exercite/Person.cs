namespace Coding.Exercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal Person(string name, int id) 
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}
