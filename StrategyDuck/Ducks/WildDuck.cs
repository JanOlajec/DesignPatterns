using System;
using StrategyDuck.Flying;
using StrategyDuck.Quacking;
using StrategyDuck.Swiming;

namespace StrategyDuck.Ducks
{
    internal class WildDuck : Duck
    {
        public WildDuck() 
        {
            QuackingStrategy = new DoQuack();
            SwimingStrategy = new DoSwim();
            FlyingStrategy = new DoFly();
        }

        public override void Display()
        {
            Console.WriteLine("I am WILD duck.");
        }
    }
}
