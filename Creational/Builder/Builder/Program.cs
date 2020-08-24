using Builder.Builder;
using Builder.Model.IBuild;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fb = new Fabricante();

            ICelular celular = null;

            celular = new AndroidBuilder();
            fb.Construtor(celular);
            Console.WriteLine($"Celular do tipo {celular.Celular.nome}");

            celular = new IphoneBuilder();
            fb.Construtor(celular);
            Console.WriteLine($"Celular do tipo {celular.Celular.nome}");
            Console.ReadKey();
        }

    }
}
