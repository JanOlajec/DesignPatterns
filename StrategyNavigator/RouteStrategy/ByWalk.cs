using System;

namespace StrategyNavigator.RouteStrategy
{
    internal class ByWalk : IRouteStrategy
    {
        public void BuildRoute(string from, string to)
        {
            Console.WriteLine($"Navigate by WALK strategy from {from} to {to}.");
        }
    }
}
