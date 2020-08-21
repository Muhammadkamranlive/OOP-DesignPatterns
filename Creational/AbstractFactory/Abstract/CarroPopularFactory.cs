using AbstractFactory.Factory;
using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda MontarRodar()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new CDPlayer();
        }
    }
}
