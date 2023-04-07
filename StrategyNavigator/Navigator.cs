using StrategyNavigator.RouteStrategy;

namespace StrategyNavigator
{
    /// <summary>
    /// Build route base on defined (selected) navigation strategy
    /// </summary>
    internal class Navigator
    {
        /// <summary>
        /// Store delegate for specific building route strategy
        /// </summary>
        public IRouteStrategy routeStrategy { get; set; }

        /// <summary>
        /// Call delegate of BuildRoute strategy
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void BuildRoute(string from, string to)
        {
            routeStrategy.BuildRoute(from, to);
        }
    }
}
