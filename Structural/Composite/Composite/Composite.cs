using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> filhos = new List<Componente>();

        public Composite(string nome):base(nome)
        {
        }

        public override void Adicionar(Componente c)
        {
            filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + nome);

            foreach(Componente filho in filhos)
            {
                filho.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(Componente c)
        {
            filhos.Remove(c);
        }
    }
}
