using _02_EventBroker.Actions;
using System;
using System.Reactive.Linq;
using static System.Console;


namespace _02_EventBroker
{
    public class Ref : Actor
    {
        public Ref(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerEvent>()
                .Subscribe(e =>
                {
                    if (e is PlayerScoredEvent scored)
                        WriteLine($"REF: player {scored.Name} has scored his {scored.GoalsScored} goal.");
                    if (e is PlayerSentOffEvent sentOff)
                        WriteLine($"REF: player {sentOff.Name} sent off due to {sentOff.Reason}.");
                });
        }
    }
}
