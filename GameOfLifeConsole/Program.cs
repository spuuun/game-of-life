using System;
using System.Collections.Generic;

namespace GameOfLifeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grid Side Length? > ");

            var sideLength = Int32.Parse(Console.ReadLine());

            Screen seed = new Screen(sideLength, sideLength);
            var populatedSeed = seed.MakeRandomSeedScreen(seed);
            Console.Write("Number of Iteration? > ");

            var iterations = Int32.Parse(Console.ReadLine());

            World world = new World();

            world.Start(iterations, populatedSeed);
        }
    }
}