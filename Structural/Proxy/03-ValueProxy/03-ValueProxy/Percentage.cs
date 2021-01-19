using System.Diagnostics;

namespace _03_ValueProxy
{
    [DebuggerDisplay("{value*100.0f}%")]
    public struct Percentage
    {
        private readonly float value;

        public Percentage(float value)
        {
            this.value = value;
        }

        public static float operator *(float f, Percentage p)
        {
            return f * p.value;
        }

        public static Percentage operator +(Percentage a, Percentage b)
        {
            return new Percentage(a.value + b.value);
        }

        public override string ToString()
        {
            return $"{value * 100}%";
        }
    }
}
