using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSort : SortTrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("QuickSorted list");
        }
    }
}
