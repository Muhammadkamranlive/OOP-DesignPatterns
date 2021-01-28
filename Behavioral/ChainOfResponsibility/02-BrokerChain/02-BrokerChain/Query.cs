using System;

namespace _02_BrokerChain
{
    public class Query
    {
        public string CreatureName;

        public Argument WhatToQuery;

        public int Value;

        public enum Argument
        {
            Attack, Defense
        }

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}
