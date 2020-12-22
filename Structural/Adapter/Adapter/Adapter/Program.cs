using System.Collections.Generic;
using MoreLinq;
using static System.Console;

namespace Adapter
{
    class Program
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        public static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        public static void DrawPoint(Point p)
        {
            Write(".");
        }
        static void Main(string[] args)
        {
            Draw();
            Draw();
            ReadLine();
        }
    }
}
