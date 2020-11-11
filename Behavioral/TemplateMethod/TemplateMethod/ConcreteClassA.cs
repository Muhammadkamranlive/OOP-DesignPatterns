using System;

namespace TemplateMethod
{
    public class ConcreteClassA : AbstractMethod
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Concrete class A - PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Concrete class A - PrimitiveOperation2");
        }
    }
}
