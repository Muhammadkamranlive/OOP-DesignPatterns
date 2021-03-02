using static System.Console;

namespace _02_ClassicVisitor
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
            var ep = new ExpressionPrinter();
            ep.Visit(e);
            WriteLine(ep.ToString());

            var calc = new ExpressionCalculator();
            calc.Visit(e);
            WriteLine($"{ep} = {calc.Result}");
            ReadKey();
        }
    }
}
