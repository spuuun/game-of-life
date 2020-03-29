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
                    if (cell.X == 0)
                    {
                        // x corner cases
                        if (cell.Y == 0)
                        {
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
                        else if (cell.Y == screen.Height - 1)
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
                        else
                        {
                            var up = screen.Generation[cell.X][cell.Y - 1].isAlive;
                            var upRight = screen.Generation[cell.X + 1][cell.Y - 1].isAlive;
                            var right = screen.Generation[cell.X + 1][cell.Y].isAlive;
                            var downRight = screen.Generation[cell.X + 1][cell.Y + 1].isAlive;
                            var down = screen.Generation[cell.X][cell.Y + 1].isAlive;
                            if (up)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (upRight)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (downRight)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (down)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (right)
                            {
                                cell.LivingNeighbors++;
                            }
                        }

                    }
                    // corner cases
                    else if (cell.X == screen.Width - 1)
                    {
                        if (cell.Y == 0)
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
                        else if (cell.Y == screen.Height - 1)
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
                        else
                        {
                            var up = screen.Generation[cell.X][cell.Y - 1].isAlive;
                            var down = screen.Generation[cell.X][cell.Y + 1].isAlive;
                            var downLeft = screen.Generation[cell.X - 1][cell.Y + 1].isAlive;
                            var left = screen.Generation[cell.X - 1][cell.Y].isAlive;
                            var upLeft = screen.Generation[cell.X - 1][cell.Y - 1].isAlive;
                            if (down)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (downLeft)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (left)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (upLeft)
                            {
                                cell.LivingNeighbors++;
                            }
                            if (up)
                            {
                                cell.LivingNeighbors++;
                            }
                        }
                    }
                    // remaining y edge cases
                    else if (cell.Y == 0)
                    {
                        var right = screen.Generation[cell.X + 1][cell.Y].isAlive;
                        var downRight = screen.Generation[cell.X + 1][cell.Y + 1].isAlive;
                        var down = screen.Generation[cell.X][cell.Y + 1].isAlive;
                        var downLeft = screen.Generation[cell.X - 1][cell.Y + 1].isAlive;
                        var left = screen.Generation[cell.X - 1][cell.Y].isAlive;
                        if (left)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (downLeft)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (down)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (downRight)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (right)
                        {
                            cell.LivingNeighbors++;
                        }
                    }

                    else if (cell.Y == screen.Height - 1)
                    {
                        var up = screen.Generation[cell.X][cell.Y - 1].isAlive;
                        var upRight = screen.Generation[cell.X + 1][cell.Y - 1].isAlive;
                        var right = screen.Generation[cell.X + 1][cell.Y].isAlive;
                        var left = screen.Generation[cell.X - 1][cell.Y].isAlive;
                        var upLeft = screen.Generation[cell.X - 1][cell.Y - 1].isAlive;
                        if (left)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (upLeft)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (up)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (upRight)
                        {
                            cell.LivingNeighbors++;
                        }
                        if (right)
                        {
                            cell.LivingNeighbors++;
                        }
                    }

                    // REGULAR CASES
                    else
                    {
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
                    }
                });
            });
            Console.WriteLine("render AFTER living neighbors eval");
            screen.RenderGrid();

            var tickedCells = DoCellTick(screen);
            var newSeed = clearAllCells(tickedCells);
            return newSeed;
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
