using static System.Console;

namespace _01_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var chess = new Chess();
            chess.Run();
            ReadKey();
        }
    }
}
