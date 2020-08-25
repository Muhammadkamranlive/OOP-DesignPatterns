using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente perm = new FuncionarioPermanente();
            perm.Nome = "Joao";
            perm.Idade = 30;
            perm.Tipo = "Permanente";

            FuncionarioPermanente perm2 = (FuncionarioPermanente)perm.Clone();
            perm2.Idade = 40;
            perm2.Nome = "Carlos";

            Console.WriteLine("Detalhe do Funcionário");
            Console.WriteLine($"Nome: {perm.Nome} e do clonado {perm2.Nome}");
            Console.WriteLine($"Idade: {perm.Idade} e do clonado {perm2.Idade}");
            Console.WriteLine($"Tipo: {perm.Tipo} e do clonado {perm2.Tipo}");
            Console.ReadKey();
        }
    }
}
