using Coding.Exercise;
using System.Collections.Generic;

namespace Exercite
{
    public class PersonFactory
    {
        private List<Person> persons = new List<Person>();

        public Person CreatePerson(string name)
        {
            var person = new Person(name, persons.Count);
            persons.Add(person);
            return person;
        }
    }
}
