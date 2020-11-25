using static System.Console;

namespace FunctionalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sarah")
                .WorskAs("Developer")
                .Build();
            WriteLine(person);
            ReadKey();
        }
    }
}
