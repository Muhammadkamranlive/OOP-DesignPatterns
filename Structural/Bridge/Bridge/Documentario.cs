using System;

namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de Documentários";
        }

        public string Status()
        {
            return "Você está assistindo - A origem de tudo";
        }

    }
}
