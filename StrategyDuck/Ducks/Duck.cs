using StrategyDuck.Quacking;
using StrategyDuck.Swiming;
using StrategyDuck.Flying;

namespace StrategyDuck
{
    internal abstract class Duck
    {
        internal IQuack QuackingStrategy { get; set; }
        internal ISwim SwimingStrategy { get; set; }
        internal IFly FlyingStrategy { get; set; }

        public abstract void Display();

        public void Quack()
        {
            QuackingStrategy.Quack();
        }

        public void Swim()
        {
            SwimingStrategy.Swim();
        }

        public void Fly()
        {
            FlyingStrategy.Fly();
        }
    }
}
