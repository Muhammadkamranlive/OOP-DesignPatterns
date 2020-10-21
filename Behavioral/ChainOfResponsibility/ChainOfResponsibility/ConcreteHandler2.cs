using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} Handler request {request}");
            }
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }
}
