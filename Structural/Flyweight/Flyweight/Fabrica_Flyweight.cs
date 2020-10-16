using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class Fabrica_Flyweight
    {
        private Dictionary<string, Tartaruga> listaDeTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;
            if (listaDeTartarugas.ContainsKey(cor))
            {
                t = listaDeTartarugas[cor];
            }
            else
            {
                switch(cor)
                {
                    case "azul":
                        t = new TartarugaAzul();
                        break;

                    case "verde":
                        t = new TartarugaVerde();
                        break;
                    case "vermelha":
                        t = new TartarugaVermelha();
                        break;
                    case "laranja":
                        t = new TartarugaLaranja();
                        break;
                    default:
                        t = new TartarugaLaranja();
                        break;
                }

                listaDeTartarugas.Add(cor, t);
            }

            return t;
        }
    }
}
