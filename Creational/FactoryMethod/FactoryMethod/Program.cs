using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar objetos de modo dinâmico em tempo de execução
            FactoryMethod fm = new FactoryMethod();
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            string escolha = Console.ReadLine();
            IPersonagem escolhido = fm.Escolher_Personagem(escolha);
            Console.WriteLine("O escolhido foi: ");
            escolhido.Escolhido();
            Console.ReadLine();
        }
    }
}
