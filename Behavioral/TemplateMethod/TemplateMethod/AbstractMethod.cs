using System;

namespace TemplateMethod
{
    public abstract class AbstractMethod
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine();
        }
    }
}
