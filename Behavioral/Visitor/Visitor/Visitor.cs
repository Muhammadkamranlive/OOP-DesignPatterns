using System;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcretElementA elementA);

        public abstract void VisitConcreteElementB(ConcretElementB elementB);
    }
}
