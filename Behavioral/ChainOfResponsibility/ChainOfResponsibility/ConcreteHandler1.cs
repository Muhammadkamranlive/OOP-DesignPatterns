using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handler request {request}");
            }
            else if(sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }
}
