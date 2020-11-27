using System;

namespace FactoryMethod
{
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }
    public class PointBadExample
    {
        private double x, y;
        
        // cannot overload with diferente params names
        public PointBadExample(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Params has no indicate about what it is, is generic
        public PointBadExample(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch(system)
            {
                case CoordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
            }
        }
    }
}
