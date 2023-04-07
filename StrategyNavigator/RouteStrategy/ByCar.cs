using System;

namespace StrategyNavigator.RouteStrategy
{
    internal class ByCar : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Navigate by CAR strategy from {from} to {to}.");
        }
    }
}
