namespace BridgeExercise
{
    class Program
    {
        public interface IRenderer
        {
            string WhatToRenderAs { get; }
        }

        public class RasterRenderer : IRenderer
        {
            public string WhatToRenderAs => "pixels";
        }

        public class VectorRenderer : IRenderer
        {
            public string WhatToRenderAs => "lines";
        }

        public abstract class Shape
        {
            protected IRenderer renderer;
            public string Name { get; set; }

            protected Shape(IRenderer renderer)
            {
                this.renderer = renderer;
            }

            public override string ToString()
            {
                return $"Drawing {Name} as {renderer.WhatToRenderAs}";
            }
        }

        public class Triangle : Shape
        {
            public Triangle(IRenderer renderer) : base(renderer)
            {
                this.Name = "Triangle";
            }
        }

        public class Square : Shape
        {
            public Square(IRenderer renderer) : base(renderer)
            {
                this.Name = "Square";
            }
        }


        static void Main(string[] args)
        {
        }
    }
}
