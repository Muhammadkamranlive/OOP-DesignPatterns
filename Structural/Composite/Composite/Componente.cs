using System;

namespace Composite
{
    public abstract class Componente
    {
        protected String nome;

        public Componente(String nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
    }
}
