using System;

namespace _02_BrokerChain
{
    public class Creature
    {
        public string Name;
        private int attack, defense;
        private Game game;

        public Creature(Game game, string name, int attack, int defense)
        {
            Name = name;
            this.attack = attack;
            this.defense = defense;
            this.game = game;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, attack);
                game.PerformQuery(this, q); // q.value
                return q.Value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, defense);
                game.PerformQuery(this, q); // q.value
                return q.Value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
        }
    }
}
