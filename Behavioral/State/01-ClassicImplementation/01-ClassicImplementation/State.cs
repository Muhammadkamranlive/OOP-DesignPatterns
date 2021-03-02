using static System.Console;

namespace _01_ClassicImplementation
{
    public abstract class State
    {
        public virtual void On(Switch sw)
        {
            WriteLine("Light is already on.");
        }

        public virtual void Off(Switch sw)
        {
            WriteLine("Light is already off.");
        }
    }
}
