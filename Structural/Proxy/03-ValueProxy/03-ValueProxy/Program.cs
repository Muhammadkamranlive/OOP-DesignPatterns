using static System.Console;

namespace _03_ValueProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(10f * 5.Percent());
            WriteLine(2.Percent() + 3.Percent());

            ReadKey();
        }
    }
}
