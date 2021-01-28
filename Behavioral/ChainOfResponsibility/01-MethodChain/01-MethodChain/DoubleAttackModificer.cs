using static System.Console;

namespace _01_MethodChain
{
    public class DoubleAttackModificer : CreatureModifier
    {
        public DoubleAttackModificer(Creature creature) : base(creature)
        {
        }

        public override  void Handle()
        {
            WriteLine($"Doubling {creature.Name}'s attack");
            creature.Attack *= 2;
            base.Handle();
        }
    }
}
