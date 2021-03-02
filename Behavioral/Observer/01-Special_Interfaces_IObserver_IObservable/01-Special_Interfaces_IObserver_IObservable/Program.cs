using System;
using System.Reactive.Linq;
using static System.Console;

namespace _01_Special_Interfaces_IObserver_IObservable
{
    class Program : IObserver<Event>
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            var person = new Person();
            var sub = person.Subscribe(this);

            person.OfType<FallsIllEvent>().Subscribe(args => WriteLine($"A doctor has been called to {args.Address}"));
            person.CatchACold();
            ReadKey();
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
            {
                WriteLine($"OnNext: A doctor has been called to {args.Address}");
            }
        }
    }
}
