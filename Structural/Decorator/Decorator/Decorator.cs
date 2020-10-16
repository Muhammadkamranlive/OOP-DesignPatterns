using System;

namespace Decorator
{
    // Decorator abstrato
    public class Decorator : ItemBiblioteca
    {
        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }

        protected ItemBiblioteca itemBiblioteca { get; set; }

        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
