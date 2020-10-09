using System;

namespace Bridge
{
    public class Filme : ICanal
    {

        public string Canal()
        {
            return "Sintonizado no canal de Filmes";
        }

        public string Status()
        {
            return "Você está assistindo - Vingadores";
        }
    }
}
