using System;
using System.Collections.Generic;
using StrategyDuck.Ducks;
using StrategyDuck.Quacking;

namespace StrategyDuck
{
    internal class Program
    {
        static void Main()
        {
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

            Console.WriteLine("Change behavior during runtime:");
            metalDuck.QuackingStrategy = new DoQuack();
            metalDuck.Display();
            metalDuck.Quack();

            Console.ReadKey();
        }
    }
}
