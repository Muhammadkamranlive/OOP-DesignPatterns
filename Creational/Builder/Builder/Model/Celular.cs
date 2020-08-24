using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    public class Celular
    {

        public Celular(String nome)
        {
            this.nome = nome;
        }

        public string nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera { get; set; }
    }
}
