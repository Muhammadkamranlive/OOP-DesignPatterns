using AbstractFactory.Factory;
using AbstractFactory.Model;
using System;

namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRodar()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new BluetoothPlayer();
        }
    }
}
