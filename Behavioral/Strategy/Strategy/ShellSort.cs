using System;
using System.Collections.Generic;

namespace Strategy
{
    class ShellSort : SortTrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell sorted list");
        }
    }
}
