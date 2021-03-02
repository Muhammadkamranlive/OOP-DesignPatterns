using static _04_SwitchExpressions.Program;
using System;

namespace _04_SwitchExpressions
{
    public class SwitchExpressions
    {
        public static Chest Manipulate(Chest chest, Actions action, bool haveKey) =>
            (chest, action, haveKey) switch
            {
                (Chest.Closed, Action.Open, _) => Chest.Open,
                (Chest.Locked, Action.Open, true) => Chest.Open,
                (Chest.Open, Action.Close, true) => Chest.Locked,
                (Chest.Open, Action.Close, false) => Chest.Closed,
                _ => chest
            };


        public static Chest Manipulate2(Chest chest, Action action, bool haveKey)
        {
            switch (chest, action, haveKey)
            {
                case (Chest.Closed, Action.Open, _):
                    return Chest.Open;
                case (Chest.Locked, Action.Open, true):
                    return Chest.Open;
                case (Chest.Open, Action.Close, true):
                    return Chest.Locked;
                case (Chest.Open, Action.Close, false):
                    return Chest.Closed;
                default:
                    Console.WriteLine("Chest unchanged");
                    return chest;
            }
        }
    }
}
