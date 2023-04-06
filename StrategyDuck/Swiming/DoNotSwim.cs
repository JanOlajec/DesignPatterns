using System;

namespace StrategyDuck.Swiming
{
    internal class DoNotSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim.");
        }
    }
}
