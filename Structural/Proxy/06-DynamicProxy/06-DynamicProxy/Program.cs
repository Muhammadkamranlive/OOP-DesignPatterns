using static System.Console;

namespace _06_DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ba = new BankAccount();
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            WriteLine(ba);
            ReadKey();
        }
    }
}
