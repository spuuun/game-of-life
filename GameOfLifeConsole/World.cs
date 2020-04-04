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
        public void Start(int iterations, Screen screen)
        {
            screen.RenderGrid();
            Screen newScreen = screen;
            for (var i = 0; i < iterations; i++)
            {
                newScreen = Tick(newScreen);
                newScreen.Generation.ForEach(row =>
                {
                    row.ForEach(cell =>
                    {
                        cell.Tick();
                    });
                });
                Console.WriteLine("RenderGrid after cell.Tick()");
                newScreen.RenderGrid();
                //newScreen.Generation.ForEach(row =>
                //{
                //    row.ForEach(cell =>
                //    {
                //        cell.ClearNeighbors();
                //    });
                //});
            }
        }

        // METHODS:
        public Screen Tick(Screen screen)
        {
            // add screen to history before altering it
            History.Add(screen);
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
            Console.WriteLine("RenderGrid from within Tick()");
            screen.RenderGrid();
            return screen;
        }
    }
}
