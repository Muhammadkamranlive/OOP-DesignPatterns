using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de Culinaria";
        }

        public string Status()
        {
            return "Você está assistindo - Bolo de laranja";
        }

    }
}
