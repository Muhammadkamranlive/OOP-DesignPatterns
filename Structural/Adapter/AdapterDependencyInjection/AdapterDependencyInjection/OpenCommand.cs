using static System.Console;
using AdapterDependencyInjection.Interfaces;

namespace AdapterDependencyInjection
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            WriteLine("Open a file!!");
        }
    }
}
