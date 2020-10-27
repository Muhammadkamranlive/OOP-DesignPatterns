using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver rc = new Receiver();
            Command cd = new ConcreteCommand(rc);
            Invoker invoker = new Invoker();

            invoker.SetCommand(cd);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
