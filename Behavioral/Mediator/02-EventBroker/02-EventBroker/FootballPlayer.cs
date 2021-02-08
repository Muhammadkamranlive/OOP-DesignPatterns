﻿using _02_EventBroker.Actions;
using System;
using System.Reactive.Linq;

namespace _02_EventBroker
{
    public class FootballPlayer : Actor
    {
        private IDisposable sub;
        public string Name { get; set; } = "Unknown Player";
        public int GoalsScored { get; set; } = 0;

        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            Name = name;

            broker.OfType<PlayerScoredEvent>()
              .Where(ps => !ps.Name.Equals(name))
              .Subscribe(ps => Console.WriteLine($"{name}: Nicely scored, {ps.Name}! It's your {ps.GoalsScored} goal!"));

            sub = broker.OfType<PlayerSentOffEvent>()
              .Where(ps => !ps.Name.Equals(name))
              .Subscribe(ps => Console.WriteLine($"{name}: See you in the lockers, {ps.Name}."));
        }

        public void Score()
        {
            GoalsScored++;
            broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalsScored });
        }

        public void AssaultReferee()
        {
            broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "violence" });
        }
    }
}
