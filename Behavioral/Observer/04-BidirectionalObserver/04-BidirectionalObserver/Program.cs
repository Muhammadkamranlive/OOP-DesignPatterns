using static System.Console;

namespace _04_BidirectionalObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product { Name = "Book" };
            var window = new Window(product);

            // want to ensure that when product name changes
            // in one component, it also changes in another

            using (var binding = new BidirectionalBinding(product, () => product.Name, window, () => window.ProductName))
            {
                // there is no infinite loop because of
                // self-assignment guard
                product.Name = "Table";
                window.ProductName = "Chair";

                WriteLine(product);
                WriteLine(window);
            }

            ReadKey();
        }
    }
}
