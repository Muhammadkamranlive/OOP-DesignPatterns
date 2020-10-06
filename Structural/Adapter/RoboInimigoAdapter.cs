using System;

namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        // Adaptar o objeto robo com tanque
        RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo novo_Robo)
        {
            this.robo = novo_Robo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
