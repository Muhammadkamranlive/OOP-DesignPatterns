using System;
using System.Collections.Generic;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortTrategy _sortTrategy;

        public void SetSortStrategy(SortTrategy sort)
        {
            _sortTrategy = sort;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortTrategy.Sort(_list);

            foreach(var name in _list)
            {
                Console.WriteLine(" " + name);
            }
        }
    }
}
