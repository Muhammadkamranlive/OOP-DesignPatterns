using static System.Console;

namespace _01_MethodChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", 2, 2);
            WriteLine(goblin);

            var root = new CreatureModifier(goblin);
            //root.Add(new NoBonusesModificer(goblin));
            root.Add(new DoubleAttackModificer(goblin));
            root.Add(new IncreasedDefenseModifier(goblin));
            root.Handle();

            WriteLine(goblin);
            ReadKey();
        }
    }
}
