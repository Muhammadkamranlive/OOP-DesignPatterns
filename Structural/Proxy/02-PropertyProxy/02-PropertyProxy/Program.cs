using static System.Console;

namespace _02_PropertyProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Creature();
            c.Agility = 10;
            c.Agility = 10;
            c.Agility = 15;
            ReadKey();
        }
    }
}
