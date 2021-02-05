
namespace _01_Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
