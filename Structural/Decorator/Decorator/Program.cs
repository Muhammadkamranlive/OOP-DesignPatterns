using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("João", "Desing Patterns", 10);
            livro.Exibe();

            Video video = new Video("Rodrigio", "Aulas avançadas", 25, 3);
            video.Exibe();

            Console.WriteLine("\nEmprestando um vídeo:");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo um vídeo:");
            emprestado.DevolverItem("Carlos");

            emprestado.Exibe();
            Console.ReadKey();
        }
    }
}
