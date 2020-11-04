using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MediadorConcreto m = new MediadorConcreto();
            ColegaConcreto1 c1 = new ColegaConcreto1(m);
            ColegaConcreto2 c2 = new ColegaConcreto2(m);

            m.Colega1 = c1;
            m.Colega2 = c2;

            c1.Enviar("Como você está?");
            c2.Enviar("Bem, obrigado!");

            Console.ReadKey();
        }
    }
}
