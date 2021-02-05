﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _01_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50)
            };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
            ReadKey();
        }
    }
}
