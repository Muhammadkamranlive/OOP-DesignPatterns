using System.Collections.Generic;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observer> _observers = new List<Observer>();

        public void Anexar(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Remover(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notificar()
        {
            foreach(var item in _observers)
            {
                item.Update();
            }
        }
    }
}
