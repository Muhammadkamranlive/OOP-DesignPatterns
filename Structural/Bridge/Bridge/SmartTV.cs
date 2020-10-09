using System;

namespace Bridge
{
    public class SmartTV
    {
        // Aqui temos a ponte (Bridge). No program chama essa interface e passamos para ela o objeto
        public ICanal CanalAtual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Canal());
            }
            else
            {
                Console.WriteLine("Selecionei um canal");
            }
        }

        public void PlayTV()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Status());
            }
            else
            {
                Console.WriteLine("Selecionei um canal para assistir");
            }
        }
    }
}
