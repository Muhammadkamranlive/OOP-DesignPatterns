using Autofac;
using static System.Console;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRenderer renderer = new RasterRenderer();
            //var circle = new Circle(renderer, 5);

            //IRenderer rendererVector = new VectorRenderer();
            //var circle2 = new Circle(rendererVector, 5);

            //circle.Draw();
            //circle.Resize(2);
            //circle.Draw();

            //circle2.Draw();
            //circle2.Resize(2);
            //circle2.Draw();
            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));
            using(var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
                circle.Draw();
                circle.Resize(2.0f);
                circle.Draw();
                ReadLine();
            }
        }
    }
}
