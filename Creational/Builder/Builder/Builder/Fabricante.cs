using Builder.Model.IBuild;
using System;

namespace Builder.Builder
{
    class Fabricante
    {
        public void Construtor(ICelular celular)
        {
            celular.BuildBateria();
            celular.BuildCamera();
            celular.BuildSistema();
            celular.BuildTela();
        }
    }
}
