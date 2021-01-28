using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MethodChain
{
    public class NoBonusesModificer : CreatureModifier
    {
        public NoBonusesModificer(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {
        }
    }
}
