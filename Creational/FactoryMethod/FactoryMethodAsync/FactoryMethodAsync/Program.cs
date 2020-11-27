using System;
using static System.Console;

namespace FactoryMethodAsync
{
    class Program
    {
        static async void Main(string[] args)
        {
            await Foo.CreateAsync();
        }
    }
}
