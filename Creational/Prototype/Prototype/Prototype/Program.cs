using static System.Console;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Copy Constructors
            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
            var jane = new Person(john);
            jane.Address.HouseNumber = 321;
            jane.Names = new[] { "Jane", "Silva" };
            WriteLine(john);
            WriteLine(jane);
            WriteLine();
            //Copy Interface
            var john2 = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));
            var jane2 = john.DeepCopy();
            jane.Address.HouseNumber = 321;
            jane.Names = new[] { "Jane", "Silva" };
            WriteLine(john2);
            WriteLine(jane2);
            ReadKey();
        }
    }
}
