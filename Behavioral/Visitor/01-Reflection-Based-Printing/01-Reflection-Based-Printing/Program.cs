using System.Text;
using static System.Console;

namespace _01_Reflection_Based_Printing
{

    class Program
    {
        static void Main(string[] args)
        {
            var e = new AdditionExpression(
              left: new DoubleExpression(1),
              right: new AdditionExpression(
                left: new DoubleExpression(2),
                right: new DoubleExpression(3)));
            var sb = new StringBuilder();
            ExpressionPrinter.Print2(e, sb);
            WriteLine(sb);
            ReadKey();
        }
    }
}
