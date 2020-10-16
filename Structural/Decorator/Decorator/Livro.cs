using System;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public Livro(string Autor, string Titulo, int numeroCopias)
        {
            this.Autor = Autor;
            this.Titulo = Titulo;
            this.NumeroCopias = numeroCopias;
        }

        public string Autor { get; set; }

        public string Titulo { get; set; }

        public override void Exibe()
        {
            Console.WriteLine("\nLivro: ----");
            Console.WriteLine("Autor: " + this.Autor);
            Console.WriteLine("Titulo: " + this.Titulo);
            Console.WriteLine("Numero Copias: " + this.NumeroCopias);
        }
    }
}
