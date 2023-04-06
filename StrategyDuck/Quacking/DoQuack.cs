using System;

namespace StrategyDuck.Quacking
{
    internal class DoQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can quack.");
        }
    }
}
