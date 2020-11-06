using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObserverConcreto(s, "X"));
            s.Anexar(new ObserverConcreto(s, "X1"));
            s.Anexar(new ObserverConcreto(s, "X2"));

            s.EstadoAssunto = "ABC";
            s.Notificar();

            s.EstadoAssunto = "ABC123";
            s.Notificar();
            Console.ReadKey();
        }
    }
}
