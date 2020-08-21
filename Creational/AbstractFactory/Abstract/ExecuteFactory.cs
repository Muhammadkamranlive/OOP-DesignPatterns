using AbstractFactory.Factory;
using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    public class ExecuteFactory
    {
        private const string LUXO = "luxo";
        private const string POPULAR = "popular";

        public static Carro MontarCarro(string tipo)
        {
            CarroFactory cf = null;

            switch(tipo)
            {
                case LUXO:
                    cf = new CarroLuxoFactory();
                    break;
                case POPULAR:
                    cf = new CarroPopularFactory();
                    break;
            }
            Carro carro = new Carro();
            carro.som = cf.MontarSom();
            carro.roda = cf.MontarRodar();
            return carro;
        }
    }
}
