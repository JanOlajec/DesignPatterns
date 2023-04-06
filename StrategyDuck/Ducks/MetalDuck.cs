using System;
using StrategyDuck.Flying;
using StrategyDuck.Quacking;
using StrategyDuck.Swiming;

namespace StrategyDuck.Ducks
{
    internal class MetalDuck : Duck
    {
        public MetalDuck()
        {
            QuackingStrategy = new DoNotQuack();
            SwimingStrategy = new DoNotSwim();
            FlyingStrategy = new DoNotFly();
        }

        public override void Display()
        {
            Console.WriteLine("I am METAL duck.");
        }
    }
}
