using System;
using static System.Console;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        // BREAK OCP PRINCIPLE
        //public enum AvaibleDrink
        //{
        //    Coffee, Tea
        //}

        //private Dictionary<AvaibleDrink, IHotDrinkFactory> factories = new Dictionary<AvaibleDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvaibleDrink drink in Enum.GetValues(typeof(AvaibleDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(
        //            Type.GetType("AbstractFactory." + Enum.GetName(typeof(AvaibleDrink), drink) + "Factory")
        //            );

        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvaibleDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        private List<Tuple<string, IHotDrinkFactory>> factories =
            new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach(var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(
                        Tuple.Create(t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            WriteLine("Available drinks:");
            for (int i = 0; i < factories.Count; i++)
            {
                var tuple = factories[i];
                WriteLine($"{i}: {tuple.Item1}");
            }

            while(true)
            {
                string s;
                if((s = Console.ReadLine()) != null && int.TryParse(s, out int i)
                    && i >= 0
                    && i < factories.Count)
                {
                    Write("Amount: ");
                    s = ReadLine();
                    if(s!= null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return factories[i].Item2.Prepare(amount);
                    }
                }
                WriteLine("Incorrect input, try again!");
            }
        }
    }
}
