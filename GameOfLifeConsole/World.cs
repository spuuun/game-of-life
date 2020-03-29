using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class World
    {
        // PROPERTIES:
        public List<Screen> History { get; set; }

        // CONSTRUCTOR:
        public World()
        {
            History = new List<Screen>();
        }

        public Screen Iterate(Screen seed)
        {
            seed.RenderGrid();



            var newSeed = Tick(seed);
            return newSeed;
        }

        // METHODS:
        public Screen Tick(Screen screen)
        {
            // add screen to history before altering it
            History.Add(screen);

            Console.WriteLine("render BEFORE living neighbors eval");
            screen.RenderGrid();
            // iterate over every cell in currentGeneration - conditionally modify cell's LivingNeighbors property
            screen.Generation.ForEach(row =>
            {
                row.ForEach(cell =>
                {
                    if (cell.X == 0 && cell.Y == 0)
                    {
                        // x corner cases
                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X + 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }

                    else if (cell.X == 0 && cell.Y == screen.Height - 1)
                    {
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    // x edgecases
                    else if (cell.X == 0 && (cell.Y > 0 && cell.Y < screen.Height - 1))
                    {
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    // corner cases
                    else if (cell.X == screen.Width - 1 && cell.Y == 0)
                    {
                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    else if (cell.X == screen.Width - 1 && cell.Y == screen.Height - 1)
                    {
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    // edge cases
                    else if (cell.X == screen.Width - 1 && (cell.Y > 0 && cell.Y < screen.Height - 1))
                    {
                        //up
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        //upLeft
                        if (screen.Generation[cell.X - 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        //left
                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        //downLeft
                        if (screen.Generation[cell.X - 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        //down
                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    // remaining y edge cases
                    else if (cell.Y == 0 && (cell.X > 0 && cell.X < screen.Width - 1))
                    {
                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }

                    else if (cell.Y == screen.Height - 1 && (cell.X > 0 && cell.X < screen.Width - 1))
                    {
                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X - 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                    // REGULAR CASES
                    else
                    {
                        if (screen.Generation[cell.X][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X + 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X + 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X + 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X - 1][cell.Y + 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X - 1][cell.Y].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }

                        if (screen.Generation[cell.X - 1][cell.Y - 1].isAlive)
                        {
                            cell.LivingNeighbors++;
                        }
                    }
                });
            });



            Console.WriteLine("render AFTER living neighbors eval");
            screen.RenderGrid();

            var tickedCells = DoCellTick(screen);
            Console.WriteLine("render AFTER calling cell.tick on each cell");
            tickedCells.RenderGrid();
            // var newSeed = clearAllCells(tickedCells);
            return tickedCells;
        }

        public Screen DoCellTick(Screen screen)
        {
            screen.Generation.ForEach(row =>
            {
                row.ForEach(cell =>
                {
                    cell.Tick();
                });
            });
            return screen;
        }

        public Screen clearAllCells(Screen screen)
        {
            screen.Generation.ForEach(row =>
            {
                row.ForEach(cell =>
                {
                    cell.ClearNeighbors();
                });
            });
            return screen;
        }
    }
}
