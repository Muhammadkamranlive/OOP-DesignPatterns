using System;

namespace Flyweight
{
    public class TartarugaVerde : Tartaruga
    {
        public TartarugaVerde()
        {
            this.condicao = "tartaruga dentro do casco";
            this.acao = "rodando no chão";
        }

        public override void MostrarCor(string cor)
        {
            this.cor = cor;
            Console.WriteLine(condicao + " " + acao + " " + cor.ToUpper());
        }
    }
}
