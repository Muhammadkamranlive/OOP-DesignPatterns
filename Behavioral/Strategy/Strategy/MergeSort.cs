using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MergeSort : SortTrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list");
        }
    }
}
