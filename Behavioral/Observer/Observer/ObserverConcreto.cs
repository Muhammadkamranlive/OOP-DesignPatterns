using System;
using System.Collections.Generic;

namespace Observer
{
    public class ObserverConcreto : Observer
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;

        public AssuntoConcreto Assunto { get; set; }

        public ObserverConcreto(AssuntoConcreto assunto, string nome)
        {
            _nome = nome;
            _assunto = assunto;
        }

        public override void Update()
        {
            this._estadoObservador = this._assunto.EstadoAssunto;
            Console.WriteLine($"Observador {this._nome} seu novo estado é {this._estadoObservador}");
        }
    }
}
