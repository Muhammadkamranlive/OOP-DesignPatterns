using System;

namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private ColegaConcreto1 _colega1;
        private ColegaConcreto2 _colega2;

        public ColegaConcreto1 Colega1
        {
            set { _colega1 = value; }
        }

        public ColegaConcreto2 Colega2
        {
            set { _colega2 = value; }
        }

        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == _colega1)
            {
                _colega2.Notificar(mensagem);
            }
            else
            {
                _colega1.Notificar(mensagem);
            }
        }
    }
}
