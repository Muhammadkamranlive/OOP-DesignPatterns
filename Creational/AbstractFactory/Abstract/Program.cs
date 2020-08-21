using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = ExecuteFactory.MontarCarro("luxo");
            Carro carro2 = ExecuteFactory.MontarCarro("popular");

            Console.WriteLine($"Carro 1 roda: {carro1.roda}, som: {carro1.som}");
            Console.WriteLine($"Carro 1 roda: {carro2.roda}, som: {carro2.som}");

            Console.ReadKey();
        }
    }
}
