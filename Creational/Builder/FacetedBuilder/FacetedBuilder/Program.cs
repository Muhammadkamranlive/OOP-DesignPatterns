using static System.Console;

namespace FacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Works
                    .At("Fabrikam")
                    .AsA("Engineer")
                    .Earning(123000)
                .Lives
                    .At("123 London Road")
                    .In("London")
                    .WithPostCode("SW12AC");

            WriteLine(person);
            ReadKey();
        }
    }
}
