using _02_EventBroker.Actions;
using System;

namespace _02_EventBroker
{
    public class Actor
    {
        protected EventBroker broker;

        public Actor(EventBroker broker)
        {
            this.broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
        }
    }
}
