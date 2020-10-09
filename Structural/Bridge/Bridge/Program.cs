using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV minhatv = new SmartTV();
            Console.WriteLine("Selecione um canal!");

            Console.WriteLine("1. Filme.\n 2- Documentário\n 3- Culinário.");

            ConsoleKeyInfo input = Console.ReadKey();

            switch(input.KeyChar)
            {
                case '1':
                    minhatv.CanalAtual = new Filme();
                    break;

                case '2':
                    minhatv.CanalAtual = new Documentario();
                    break;

                case '3':
                    minhatv.CanalAtual = new Culinaria();
                    break;
            }

            Console.WriteLine();

            minhatv.ExibeCanalSintonizado();
            minhatv.PlayTV();

            Console.ReadKey();
        }
    }
}
