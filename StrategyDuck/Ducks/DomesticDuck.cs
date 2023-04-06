using StrategyDuck.Flying;
using StrategyDuck.Quacking;
using StrategyDuck.Swiming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.Ducks
{
    internal class DomesticDuck : Duck
    {
        public DomesticDuck()
        {
            QuackingStrategy = new DoQuack();
            SwimingStrategy = new DoSwim();
            FlyingStrategy = new DoPartiallyFly();
        }

        public override void Display()
        {
            Console.WriteLine("I am DOMESTIC duck.");
        }
    }
}
