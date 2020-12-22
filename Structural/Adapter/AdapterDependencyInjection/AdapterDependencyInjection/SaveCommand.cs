using static System.Console;
using AdapterDependencyInjection.Interfaces;

namespace AdapterDependencyInjection
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            WriteLine("Save a file!!");
        }
    }
}
