using System;
namespace State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Contexto context)
        {
            context.State = new ConcreteState();
        }
    }
}
