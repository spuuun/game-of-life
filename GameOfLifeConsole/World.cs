using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class World
    {
        // METHODS:
        public void RenderGrid()
        {
            // render grid of living and dead cells
            var screen0 = new List<List<Cell>>();
            var Width = 35;
            var Height = 35;


            for (var y = 0; y < Height; y++)
            {
                var sublist = new List<Cell>();
                for (var x = 0; x < Width; x++)
                {
                    var newCell = new Cell(x, y)
                    {
                        Y = y,
                        X = x
                    };
                    sublist.Add(newCell);
                }
                screen0.Add(sublist);
            }
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
