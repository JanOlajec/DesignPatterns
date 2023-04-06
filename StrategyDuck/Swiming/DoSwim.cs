using System;

namespace StrategyDuck.Swiming
{
    internal class DoSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can swim.");
        }
    }
}
