using System;
using StrategyDuck.Flying;
using StrategyDuck.Quacking;
using StrategyDuck.Swiming;

namespace StrategyDuck.Ducks
{
    internal class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            QuackingStrategy = new DoNotQuack();
            SwimingStrategy = new DoSwim();
            FlyingStrategy = new DoNotFly();
        }

        public override void Display()
        {
            Console.WriteLine("I am WOODEN duck.");
        }
    }
}
