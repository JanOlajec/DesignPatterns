using System;

namespace StrategyDuck.Flying
{
    internal class DoNotFly : IFly
    {
        public void Fly() 
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
