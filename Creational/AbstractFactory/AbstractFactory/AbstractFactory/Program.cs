using static System.Console;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvaibleDrink.Tea, 100);
            //drink.Consume();
            //WriteLine();

            //var drink2 = machine.MakeDrink(HotDrinkMachine.AvaibleDrink.Coffee, 100);
            //drink2.Consume();
            //ReadKey();
            var drink = machine.MakeDrink();
            drink.Consume();
            ReadKey();
        }
    }
}
