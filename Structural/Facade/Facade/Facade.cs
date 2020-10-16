using System;

namespace Facade
{
    public class Facade
    {
        public SubSistemaUm um;
        public SubSistemaDois dois;
        public SubSistemaTres tres;

        public Facade()
        {
            um = new SubSistemaUm();
            dois = new SubSistemaDois();
            tres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMétodo A");
            dois.MetodoDois();
            tres.MetodoTres();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMétodo B");
            um.MetodoUm();
            tres.MetodoTres();
        }
    }
}
