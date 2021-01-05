using static System.Console;

namespace _01.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder();
            cb.AppendLine("class Foo")
              .AppendLine("{")
              .AppendLine("}");

            CodeBuilder s = "Hello ";
            s += "World";

            WriteLine(cb);
            WriteLine(s);
            ReadKey();
        }
    }
}
