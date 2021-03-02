using System.Text;
using static System.Console;

namespace _03_SwitchBasedStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "1234";
            var state = State.Locked;
            var entry = new StringBuilder();

            while (true)
            {
                switch (state)
                {
                    case State.Locked:
                        entry.Append(ReadKey().KeyChar);

                        if (entry.ToString() == code)
                        {
                            state = State.Unlocked;
                            break;
                        }

                        if (!code.StartsWith(entry.ToString()))
                        {
                            // the code is blatantly wrong
                            state = State.Failed;
                        }
                        break;
                    case State.Failed:
                        CursorLeft = 0;
                        WriteLine("FAILED");
                        entry.Clear();
                        state = State.Locked;
                        break;
                    case State.Unlocked:
                        CursorLeft = 0;
                        WriteLine("UNLOCKED");
                        return;
                }
            }
        }
    }
}
