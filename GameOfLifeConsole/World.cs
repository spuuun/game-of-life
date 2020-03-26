using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class World
    {
        // METHODS:
        public void RenderGrid(Screen screen)
        {
            // render grid of living and dead cells
        }

        public void Seed()
        {
            // alter state of initial grid based on user interaction - i.e. toggle cells isAlive property onClick
            // STRETCH GOAL: allow user to change grid size

        }

        public void Start()
        {
            // start iterating generations
        }

        public void Stop()
        {
            // stop iterating generations
        }

        public Screen Tick(Screen currentGeneration)
        {
            var NextGeneration = new Screen();

            // iterate over every cell in currentGeneration
            // evaluate living/dead for next generation - add the result to NextGeneration

            return NextGeneration;
        }
    }
}
