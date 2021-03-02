using static System.Console;

namespace _01_ClassicImplementation
{
    public class OnState : State
    {
        public OnState()
        {
            WriteLine("Light turned on.");
        }
        public override void Off(Switch sw)
        {
            WriteLine("Turning light off...");
            sw.State = new OffState();
        }
    }
}
