using static System.Console;

namespace BuilderInheritanceWithRecursiveGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = Person.New
                .Called("Romero")
                .WorksAsA("Software Engineer")
                .Build();
            WriteLine(me);
            ReadKey();
        }
    }
}
