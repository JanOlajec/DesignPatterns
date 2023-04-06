using System;

namespace StrategyDuck.Quacking
{
    internal class DoNotQuack : IQuack
    {
        public void Quack() 
        {
            Console.WriteLine("I can't quack.");
        }
    }
}
