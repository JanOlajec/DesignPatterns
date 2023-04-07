using StrategyNavigator.RouteStrategy;
using System;

namespace StrategyNavigator
{
    internal class Program
    {
        static void Main()
        {
            // Navigator object without navigate strategy - it will be defined (changed) during runtime by user selection
            Navigator navigator = new Navigator();
            
            // Define/specify navigate strategy
            navigator.routeStrategy = new ByCar();
            navigator.BuildRoute("A", "B");
            navigator.BuildRoute("C", "D");

            // Change navigate strategy during runtime
            navigator.routeStrategy = new ByBicycle();
            navigator.BuildRoute("E", "F");

            // Change navigate strategy during runtime
            navigator.routeStrategy = new ByWalk();
            navigator.BuildRoute("G", "H");
            navigator.BuildRoute("I", "J");

            Console.ReadKey();
        }
    }
}
