using System;

namespace Sigleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Existe apenas uma bola em "campo"
            Ball jogador1 = Ball.GetObj;
            jogador1.Mensagem("Estou com a bola, passando para o jogador 2");
            jogador1.addPass();

            Ball jogador2 = Ball.GetObj;
            jogador2.Mensagem("Passando para o jogador 3");
            jogador1.addPass();

            Ball jogador3 = Ball.GetObj;
            jogador3.Mensagem("Chutei ao gol");
            jogador1.addKick();

            Console.ReadKey();
        }
    }
}
