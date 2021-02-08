using _02_EventBroker.Actions;
using System;
using System.Reactive.Linq;
using static System.Console;

namespace _02_EventBroker
{
    public class FootballCoach : Actor
    {
        public FootballCoach(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerScoredEvent>()
                .Subscribe(ps =>
                {
                    if (ps.GoalsScored < 3)
                        WriteLine($"Coach: well done, {ps.Name}!");
                });

            broker.OfType<PlayerSentOffEvent>()
                .Subscribe(ps =>
                {
                    if (ps.Reason == "violence")
                        WriteLine($"Coach: How could you, {ps.Name}?");
                });
        }
    }
}
