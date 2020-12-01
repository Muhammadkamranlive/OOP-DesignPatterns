using static System.Console;

namespace PrototypeSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
            var jane = john.DeepCopy();
            jane.Address.HouseNumber = 321;
            jane.Names = new[] { "Jane", "Silva" };
            WriteLine(john);
            WriteLine(jane);
            WriteLine();

            var john2 = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
            var jane2 = john.DeepCopyXml();
            jane2.Address.HouseNumber = 321;
            jane2.Names = new[] { "Jane", "Silva" };
            WriteLine(john2);
            WriteLine(jane2);
            ReadKey();
        }
    }
}
