using static System.Console;

namespace Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            WriteLine($"Drawing a circle with radius {radius}");
        }
    }
}