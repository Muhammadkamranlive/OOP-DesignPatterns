using static System.Console;

namespace Exercite
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = PersonFactory.CreatePerson("Person 1");
            var p2 = PersonFactory.CreatePerson("Person 2");
            var p3 = PersonFactory.CreatePerson("Person 3");

            WriteLine(p1);
            WriteLine(p2);
            WriteLine(p3);

            ReadKey();
        }
    }
}
