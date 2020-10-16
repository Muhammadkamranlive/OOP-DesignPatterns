using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---# Flyweight");

            Fabrica_Flyweight fabrica = new Fabrica_Flyweight();
            
            string cor = string.Empty;

            Tartaruga tartaruga;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Cor da tartaruga: ");
                cor = Console.ReadLine();
                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.MostrarCor(cor);
                Console.WriteLine();
                Console.WriteLine("-----------------");
            }
        }
    }
}
