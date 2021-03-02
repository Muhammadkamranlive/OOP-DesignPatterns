using static System.Console;

namespace _06_Exercise
{
    class Program
    {
        public class CombinationLock
        {
            // you need to be changing this on user input
            public string Status;
            private string inicialState;

            public CombinationLock(int[] combination)
            {
                Status = "LOCKED";
                inicialState = string.Join("", combination);
            }
            
            public void EnterDigit(int digit)
            {
                if (Status.Equals("LOCKED"))
                    Status = string.Empty;

                Status += digit.ToString();
                if (Status.Equals(inicialState))
                {
                    Status = "OPEN";
                }
                else
                {
                    var partLock = inicialState.Substring(0, Status.Length);
                    if(!Status.Equals(partLock))
                        Status = "ERROR";
                }
                WriteLine(Status);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
