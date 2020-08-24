using Builder.Model;
using Builder.Model.IBuild;
using System;

namespace Builder.Builder
{
    class IphoneBuilder : ICelular
    {
        public Celular celular;

        public IphoneBuilder()
        {
            this.celular = new Celular("IPhone");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1550";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "9";
        }

        public Celular Celular
        {
            get
            {
                return this.celular;
            }
        }
    }
}
