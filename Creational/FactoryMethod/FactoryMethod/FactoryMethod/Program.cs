using System;
using static System.Console;
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            WriteLine(point);
            ReadKey();
        }
    }
}
