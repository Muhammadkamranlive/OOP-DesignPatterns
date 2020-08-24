using Builder.Model;
using Builder.Model.IBuild;
using System;

namespace Builder.Builder
{
    class AndroidBuilder : ICelular
    {
        public Celular celular;

        public AndroidBuilder()
        {
            this.celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this.celular.tela = "7";
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
