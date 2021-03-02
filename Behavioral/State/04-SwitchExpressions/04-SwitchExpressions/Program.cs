using static System.Console;

namespace _04_SwitchExpressions
{
    class Program
    {
        public enum Chest
        {
            Open,
            Closed,
            Locked
        }

        public enum Actions
        {
            Open,
            Close
        }

        static void Main(string[] args)
        {
            Chest chest = Chest.Locked;
            WriteLine($"Chest is {chest}");

            // unlock with key
            chest = SwitchExpressions.Manipulate(chest, Actions.Open, true);
            WriteLine($"Chest is now {chest}");

            // close it!
            chest = SwitchExpressions.Manipulate(chest, Actions.Close, false);
            WriteLine($"Chest is now {chest}");

            // close it again!
            chest = SwitchExpressions.Manipulate(chest, Actions.Close, false);
            WriteLine($"Chest is now {chest}");
            ReadKey();
        }
    }
}
