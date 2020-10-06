
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2018 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            IAtaqueInimigo robo_Adapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine("================= Robo ===================");
            R2D2.AndarFrente();
            R2D2.EsmagarComMaos();
            R2D2.ReagirContraHumano("João");

            Console.WriteLine("================= TANQUE ===================");
            rx2018.ArmaFogo();
            rx2018.Movimenta();
            rx2018.Pilotar("Bruce Dickinson");


            Console.WriteLine("================= robo_Adapter ===================");
            robo_Adapter.ArmaFogo();
            robo_Adapter.Movimenta();
            robo_Adapter.Pilotar("Bruce Dickinson");

            Console.ReadLine();

        }
    }
}
