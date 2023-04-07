using StrategyDuck.Quacking;
using StrategyDuck.Swiming;
using StrategyDuck.Flying;

namespace StrategyDuck
{
    /// <summary>
    /// Super-class Duck for specific derived classes 
    /// </summary>
    internal abstract class Duck
    {
        internal IQuack QuackingStrategy { get; set; }
        internal ISwim SwimingStrategy { get; set; }
        internal IFly FlyingStrategy { get; set; }

        /// <summary>
        /// Each derived class implement own Display() method which describe duck type.
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Call delegate for Quack behavior (strategy)
        /// </summary>
        public void Quack()
        {
            QuackingStrategy.Quack();
        }

        /// <summary>
        /// Call delegate for Swim behavior (strategy)
        /// </summary>
        public void Swim()
        {
            SwimingStrategy.Swim();
        }

        /// <summary>
        /// Call delegate for Fly behavior (strategy)
        /// </summary>
        public void Fly()
        {
            FlyingStrategy.Fly();
        }
    }
}
