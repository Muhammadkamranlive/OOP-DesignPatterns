using static System.Console;

namespace _01_NullObject
{
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            WriteLine(msg);
        }

        public void Warn(string msg)
        {
            WriteLine("WARNING: " + msg);
        }
    }
}
