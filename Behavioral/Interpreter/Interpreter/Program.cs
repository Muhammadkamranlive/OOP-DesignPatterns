using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Context context = new Context(romano);

            List<Expressao> expLst = new List<Expressao>();

            expLst.Add(new MilharesExpressao());
            expLst.Add(new CentenasExpressao());
            expLst.Add(new DezenasExpressao());
            expLst.Add(new UnidadeExpressao());

            foreach(var exp in expLst)
            {
                exp.Interpretador(context);
            }

            Console.WriteLine($"{romano} = {context.Output}");
            Console.ReadKey();
        }
    }
}
