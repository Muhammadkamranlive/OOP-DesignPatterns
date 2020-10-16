using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {

        }

        protected List<string> emprestados = new List<string>();

        public void EmprestarItem(string Nome)
        {
            this.emprestados.Add(Nome);
            this.itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string Nome)
        {
            this.emprestados.Remove(Nome);
            this.itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach(string item in this.emprestados)
            {
                Console.WriteLine("Emprestados: " + item);
            }
        }
    }
}
