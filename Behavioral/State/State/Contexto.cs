using System;
using System.Resources;

namespace State
{
    public class Contexto
    {
        private State _state;

        public Contexto(State state)
        {
            _state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("Estado: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
