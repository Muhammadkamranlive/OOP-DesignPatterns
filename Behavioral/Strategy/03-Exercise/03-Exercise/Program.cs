using System;
using System.Numerics;

namespace _03_Exercise
{
    class Program
    {
        public interface IDiscriminantStrategy
        {
            double CalculateDiscriminant(double a, double b, double c);
        }

        public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
        {
            public double CalculateDiscriminant(double a, double b, double c)
            {
                return (Math.Pow(b, 2) - (4 * a * c));
            }
        }

        public class RealDiscriminantStrategy : IDiscriminantStrategy
        {
            // todo (return NaN on negative discriminant!)
            public double CalculateDiscriminant(double a, double b, double c)
            {
                var result = (Math.Pow(b, 2) - (4 * a * c));
                return result < 0 ? double.NaN : result;
            }
        }

        public class QuadraticEquationSolver
        {
            private readonly IDiscriminantStrategy strategy;

            public QuadraticEquationSolver(IDiscriminantStrategy strategy)
            {
                this.strategy = strategy;
            }

            public Tuple<Complex, Complex> Solve(double a, double b, double c)
            {
                var discriminant = new Complex(strategy.CalculateDiscriminant(a, b, c), 0);
                var root = Complex.Sqrt(discriminant);
                var plus = (-b + root) / 2 * a;
                var minus = (-b - root) / 2 * a;
                return Tuple.Create(plus, minus);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
