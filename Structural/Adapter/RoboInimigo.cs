using System;

namespace Adapter
{
    public class RoboInimigo
    {
        /*Objeto a ser adaptado (adaptee)*/
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"Roubo inimigo causo {danoAtaque} de dano com o Esmagar");
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine($"Roubo inimigo andou {movimento} para frente!");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine($"O robo inimigo ataca {piloto}!");
        }
    }
}
