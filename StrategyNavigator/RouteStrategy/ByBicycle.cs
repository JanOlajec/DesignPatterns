using System;

namespace StrategyNavigator.RouteStrategy
{
    internal class ByBicycle : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Navigate by BICYCLE strategy from {from} to {to}.");
        }
    }
}
