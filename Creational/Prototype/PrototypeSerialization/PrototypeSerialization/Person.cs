using System;

namespace PrototypeSerialization
{
    [Serializable]
    public class Person
    {
        public string[] Names;
        public Address Address;

        public Person() { } // Need for xml serializable

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }
    }
}
