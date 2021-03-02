using static System.Console;

namespace _01_ClassicImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not good example
            var switchLight = new Switch();
            switchLight.On();
            switchLight.Off();
            switchLight.Off();
        }
    }
}
