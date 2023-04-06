using System;

namespace StrategyDuck.Flying
{
    internal class DoPartiallyFly : IFly
    {
        public void Fly() 
        {
            Console.WriteLine("I can only partially fly.");
        }
    }
}
