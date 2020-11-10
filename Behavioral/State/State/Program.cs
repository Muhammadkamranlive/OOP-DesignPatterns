using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto c = new Contexto(new ConcreteState());
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }
}
