using System;

namespace State
{
    public class ConcreteState : State
    {
        public override void Handle(Contexto context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
