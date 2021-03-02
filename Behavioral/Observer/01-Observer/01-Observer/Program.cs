using static System.Console;

namespace _01_Observer
{
    class Program
    {
        static void Main()
        {
            var person = new Person();

            person.FallsIll += CallDoctor;

            person.CatchACold();

            ReadKey();
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            WriteLine($"A doctor has been called to {eventArgs.Address}");
        }

    }
}
