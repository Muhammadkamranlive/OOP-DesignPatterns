using System.Collections.Generic;
using System.Linq;

namespace _02_CompositeCommand
{
    public class CompositeBankAccountCommand : List<BankAccountCommand>
    {
        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public virtual void Undo()
        {
            foreach (var cmd in ((IEnumerable<BankAccountCommand>)this).Reverse())
            {
                cmd.Undo();
            }
        }
    }
}
