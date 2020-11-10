using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList student = new SortedList();
            student.Add("1");
            student.Add("2");
            student.Add("3");
            student.Add("4");

            student.SetSortStrategy(new QuickSort());
            student.Sort();

            student.SetSortStrategy(new ShellSort());
            student.Sort();

            student.SetSortStrategy(new MergeSort());
            student.Sort();

            Console.ReadKey();
        }
    }
}
