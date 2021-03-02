using static System.Console;

namespace _01_NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var log = new ConsoleLog();
            //ILog log = null;
            //var log = new NullLog();
            var log = Null<ILog>.Instance;
            var ba = new BankAccount(log);
            ba.Deposit(100);
            ba.Withdraw(200);

            ReadKey();
        }
    }
}
