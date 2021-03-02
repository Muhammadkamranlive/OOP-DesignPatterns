using System.Collections.Generic;
using System.ComponentModel;

namespace _03_ObservebleCollections
{
    public class Market
    {
        // public List<float> Prices = new List<float>();
        // public event EventHandler<PriceAddedEventArgs> PriceAdded;
        public BindingList<float> Prices = new BindingList<float>();

        public void AddPrice(float price)
        {
            Prices.Add(price);
            // PriceAdded?.Invoke(this, new PriceAddedEventArgs{ Price = price });
        }
    }
}
