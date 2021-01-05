namespace _02.DynamicDecoratorComposition
{
    public class ColoredShape : IShape
    {
        private IShape shape;
        private string color;

        public ColoredShape(string color, IShape shape)
        {
            this.color = color;
            this.shape = shape;
        }

        public string AsString() => $"{shape.AsString()} has the color {color}";
    }
}
