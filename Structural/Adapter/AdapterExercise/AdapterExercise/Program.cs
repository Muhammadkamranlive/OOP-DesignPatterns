using static System.Console;

namespace AdapterExercise
{
    class Program
    {
        public class Square
        {
            public int Side;
        }

        public interface IRectangle
        {
            int Width { get; }
            int Height { get; }
        }

        public static class ExtensionMethods
        {
            public static int Area(IRectangle rc)
            {
                return rc.Width * rc.Height;
            }
        }

        public class SquareToRectangleAdapter : IRectangle
        {
            private int widthRectangle;
            private int heightRectangle;
            public int Width => widthRectangle;

            public int Height => heightRectangle;

            public SquareToRectangleAdapter(Square square)
            {
                widthRectangle = square.Side;
                heightRectangle = square.Side;
            }

            public override string ToString()
            {
                return $"Area do Rectangulo: {ExtensionMethods.Area(this)}";
            }
        }

        static void Main(string[] args)
        {
            var square = new Square();
            square.Side = 5;

            var objAdapter = new SquareToRectangleAdapter(square);
            WriteLine(objAdapter);
            ReadLine();
        }
    }
}
