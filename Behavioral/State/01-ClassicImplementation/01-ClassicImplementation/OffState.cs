using static System.Console;


namespace _01_ClassicImplementation
{

    public class OffState : State
    {
        public OffState()
        {
            WriteLine("Light turned off.");
        }

        public override void On(Switch sw)
        {
            WriteLine("Turning light on...");
            sw.State = new OnState();
        }
    }
}
