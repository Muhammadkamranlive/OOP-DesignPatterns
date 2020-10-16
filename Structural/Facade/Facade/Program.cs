using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.MetodoA();
            f.MetodoB();

            Console.ReadKey();
        }
    }
}
