﻿using System;
using System.Linq;
using System.Collections.Generic;


namespace FunctionalBuilder
{
    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new ()
    {
        private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();

        public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));

        public TSelf Do(Action<TSubject> action) => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return (TSelf)this;
        }
    }
}
