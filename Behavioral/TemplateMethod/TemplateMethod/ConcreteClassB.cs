using System;

namespace TemplateMethod
{
    public class ConcreteClassB : AbstractMethod
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Concrete class B - PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Concrete class B - PrimitiveOperation2");
        }
    }
}
