using System;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypeExercise
{
    class Program
    {
        [Serializable]
        public class Point
        {
            public int X, Y;

            public override string ToString()
            {
                return $"{nameof(X)} : {(X)}, {nameof(Y)} : {Y}";
            }

            public Point DeepCopy()
            {
                var stream = new MemoryStream();
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                Point copy = (Point)formatter.Deserialize(stream);
                stream.Close();
                return copy;
            }

        }

        public class Line
        {
            public Point Start, End;

            public Line(Point start, Point end)
            {
                Start = start;
                End = end;
            }

            public Line DeepCopy()
            {
                return new Line(Start.DeepCopy(),End.DeepCopy());
            }

            public override string ToString()
            {
                return $"{nameof(Start)} : {nameof(Start.X)}= {Start.X} and {nameof(Start.Y)}= {Start.Y} " +
                    $"\n{nameof(End)}   : {nameof(End.X)}= {End.X} and {nameof(End.Y)}= {End.Y}";
            }
        }

        static void Main(string[] args)
        {
            var start = new Point();
            var end = new Point();
            start.X = 1;
            start.Y = 2;
            end.X = 10;
            end.Y = 11;

            var original = new Line(start, end);

            var copy = original.DeepCopy();
            copy.Start.X = 100;
            copy.Start.Y = 200;

            WriteLine(original);
            WriteLine(copy);
            ReadLine();
        }
    }
}
