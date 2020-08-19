using System;

namespace Sigleton
{
    // Sealed = não pode ser herdada
    // Classe para entregar e gerenciar o objeto
    public sealed class Ball
    {
        public static Ball obj = null;

        private int pass { get; set; }

        private int kick { get; set; }

        public static Ball GetObj
        {
            get
            {
                if (obj == null)
                {
                    obj = new Ball();
                    Console.WriteLine("Bola CRAIDA!!");
                }
                return obj;
            }
        }

        public void addPass()
        {
            this.pass += 1;
            Console.WriteLine($"Passe de número: {this.pass}");
            Console.WriteLine();
        }

        public void addKick()
        {
            this.kick += 1;
            Console.WriteLine($"Chute de numero: {obj.kick}");
            Console.WriteLine();
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
