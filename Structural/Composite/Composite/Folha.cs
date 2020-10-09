using System;

namespace Composite
{
    public class Folha : Componente
    {

        public Folha(string nome) : base(nome)
        {

        }
        public override void Adicionar(Componente c)
        {
            Console.WriteLine("Não é possível adicionar a folha!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + nome);
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Não é possível remover a folha!");
        }
    }
}
