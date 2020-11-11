using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMethod abstract_a = new ConcreteClassA();
            abstract_a.TemplateMethod();

            AbstractMethod abstract_b = new ConcreteClassB();
            abstract_b.TemplateMethod();

            Console.ReadKey();
        }
    }
}
