using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public Video(string Diretor, string Titulo, int MinutosDuracao, int numeroCopias)
        {
            this.Diretor = Diretor;
            this.Titulo = Titulo;
            this.MinutosDuracao = MinutosDuracao;
            this.NumeroCopias = numeroCopias;
        }

        public string Diretor { get; set; }

        public string Titulo { get; set; }

        public int MinutosDuracao { get; set; }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo: ----");
            Console.WriteLine("Diretor: " + this.Diretor);
            Console.WriteLine("Titulo: " + this.Titulo);
            Console.WriteLine("Duração: " + this.MinutosDuracao);
            Console.WriteLine("Numero Copias: " + this.NumeroCopias);
        }
    }
}
