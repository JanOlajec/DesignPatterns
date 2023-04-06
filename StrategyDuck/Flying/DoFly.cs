using System;

namespace StrategyDuck.Flying
{
    internal class DoFly : IFly
    {
        public void Fly() 
        {
            Console.WriteLine("I can fly.");
        }
    }
}
