using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStruture o = new ObjectStruture();
            o.Add(new ConcretElementA());
            o.Add(new ConcretElementB());

            ConcretVisitor1 v1 = new ConcretVisitor1();
            ConcretVisitor2 v2 = new ConcretVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }
}
