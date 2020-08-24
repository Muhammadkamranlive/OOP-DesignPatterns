using System;
namespace Builder.Model.IBuild
{
    public interface ICelular
    {
        void BuildTela();
        void BuildBateria();
        void BuildSistema();
        void BuildCamera();

        Celular Celular { get; }
    }
}
