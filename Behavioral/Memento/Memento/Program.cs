using System;
using System.Security.Cryptography.X509Certificates;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMement();

            o.State = "Off";
            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
