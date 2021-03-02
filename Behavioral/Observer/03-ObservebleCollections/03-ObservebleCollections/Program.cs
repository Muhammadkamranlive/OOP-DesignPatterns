using System.ComponentModel;
using static System.Console;

namespace _03_ObservebleCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();
            //market.PriceAdded += (sender, eventArgs) =>
            //{
            //    WriteLine($"Added price {eventArgs.Price}");
            //};
            //market.AddPrice(123);

            market.Prices.ListChanged += (sender, eventArgs) => // Subscribe
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    WriteLine($"Added price {((BindingList<float>)sender)[eventArgs.NewIndex]}");
                }
            };
            market.AddPrice(123);
            // 1) How do we know when a new item becomes available?

            // 2) how do we know when the market is done supplying items?
            // maybe you are trading a futures contract that expired and there will be no more prices

            // 3) What happens if the market feed is broken?

            ReadKey();
        }
    }
}
