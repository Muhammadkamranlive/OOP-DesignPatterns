using System;
namespace Visitor
{
    public class ConcretVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcretElementA elementA)
        {
            Console.WriteLine("{0} visitado por {1}", elementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcretElementB elementB)
        {
            Console.WriteLine("{0} visitado por {1}", elementB.GetType().Name, this.GetType().Name);
        }
    }
}
