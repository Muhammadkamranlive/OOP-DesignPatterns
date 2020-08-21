using System;
using AbstractFactory.Model;

namespace AbstractFactory.Factory
{
    public abstract class CarroFactory
    {
        public abstract Roda MontarRodar();
        public abstract Som MontarSom();
    }
}
