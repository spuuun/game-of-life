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
            string bars = new String('-', screen.Width * 2);
            Console.WriteLine(bars);

            screen.Generation.ForEach(row =>
            {
                row.ForEach(cell =>
                {
                    // Console.Write(cell.PrintedValue);
                    Console.Write($"| {cell.PrintedValue}, ln:{cell.LivingNeighbors} ");
                });

                Console.WriteLine("|");
            });

            Console.WriteLine(bars);
            // render grid of living and dead cells

            // var screen0 = new List<List<Cell>>();
            // var Width = 35;
            // var Height = 35;


            // for (var y = 0; y < Height; y++)
            // {
            //     var sublist = new List<Cell>();
            //     for (var x = 0; x < Width; x++)
            //     {
            //         var newCell = new Cell(x, y)
            //         {
            //             Y = y,
            //             X = x
            //         };
            //         sublist.Add(newCell);
            //     }
            //     screen0.Add(sublist);
            // }
        }

        public void Tick(Screen screen)
        {
            // iterate over every cell in currentGeneration
            // evaluate living/dead for next generation - add the result to NextGeneration
            screen.Generation.ForEach(row =>
            {

                row.ForEach(cell =>
                {

                    // var up = screen.Generation[cell.X][cell.Y - 1].isAlive;
                    // var upRight = screen.Generation[cell.X + 1][cell.Y - 1].isAlive;
                    // var right = screen.Generation[cell.X + 1][cell.Y].isAlive;
                    // var left = screen.Generation[cell.X - 1][cell.Y].isAlive;
                    // var upLeft = screen.Generation[cell.X - 1][cell.Y - 1].isAlive;
                    // var downRight = screen.Generation[cell.X + 1][cell.Y + 1].isAlive;
                    // var down = screen.Generation[cell.X][cell.Y + 1].isAlive;
                    // var downLeft = screen.Generation[cell.X - 1][cell.Y + 1].isAlive;


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

                    cell.Tick();

                });
            });

            RenderGrid(screen);
        }



        public void Seed()
        {
            // alter state of initial grid based on user interaction - i.e. toggle cells isAlive property onClick
            // STRETCH GOAL: allow user to change grid size

        }


    }
}
