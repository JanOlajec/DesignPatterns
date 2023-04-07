using System;
using System.Collections.Generic;
using StrategyDuck.Ducks;
using StrategyDuck.Quacking;

namespace StrategyDuck
{
    internal class Program
    {
        /// <summary>
        /// Duck simulator application :-) with approach of Strategy design pattern
        /// </summary>
        static void Main()
        {   
            // Each duck-type have own approach how to do behavior (strategy): quack, swim, fly.
            // See super-class Duck. 
            WildDuck wildDuck = new WildDuck();
            DomesticDuck domesticDuck = new DomesticDuck();
            WoodenDuck woodenDuck = new WoodenDuck();
            MetalDuck metalDuck = new MetalDuck();

            List<Duck> flock = new List<Duck>
            {
                wildDuck,
                domesticDuck,
                woodenDuck,
                metalDuck
            };

            foreach (Duck duck in flock)
            {
                duck.Display();
                duck.Quack();
                duck.Swim();
                duck.Fly();
                
                Console.WriteLine();
            }

            // As duck realize behavior with delegate (over interface), it can be changed during runtime. 
            Console.WriteLine("Change behavior during runtime:");
            metalDuck.QuackingStrategy = new DoQuack();
            metalDuck.Display();
            metalDuck.Quack();

            Console.ReadKey();
        }
    }
}
