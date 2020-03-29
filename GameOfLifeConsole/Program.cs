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

            Console.Write("Number of Iteration? > ");
            var iterations = Int32.Parse(Console.ReadLine());

            World world = new World();

            // seed.RenderGrid();

            Screen newSeed = world.Iterate(seed);

            for (var i = 0; i < iterations - 1; i++)
            {
                newSeed = world.Iterate(newSeed);
            }
        }
    }
}