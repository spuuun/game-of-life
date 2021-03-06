﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class Screen
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<List<Cell>> Generation { get; set; } = new List<List<Cell>>();
        public int LivingNeighbors { get; set; }

        public Screen(int x, int y)
        {
            Width = x;
            Height = y;

            for (var i = 0; i < Height; i++)
            {
                var sublist = new List<Cell>();
                for (var j = 0; j < Width; j++)
                {
                    var newCell = new Cell(j, i);
                    sublist.Add(newCell);
                }
                this.Generation.Add(sublist);
            }
        }

        public Screen MakeRandomSeedScreen(Screen blankScreen)
        {

            for (var i = 0; i < blankScreen.Height; i++)
            {
                // var sublist = new List<Cell>();
                blankScreen.Generation.ForEach(row =>
                {
                    row.ForEach(cell =>
                    {
                        cell.isAlive = GetRandomBool();
                    });
                });
            }
            return blankScreen;
        }

        public bool GetRandomBool()
        {
            var random = new Random().Next(2);
            bool randomBool;

            if (random == 0)
            {
                randomBool = false;
            }
            else
            {
                randomBool = true;
            }

            return randomBool;
        }

        public void RenderGrid()
        {
            // render grid of living and dead cells
            string bars = new String('-', this.Width * 2);
            Console.WriteLine(bars);

            this.Generation.ForEach(row =>
            {
                row.ForEach(cell =>
                {
                    Console.Write($"{cell.PrintedValue}");
                    // Console.Write($"({cell.X},{cell.Y})");
                });
                Console.WriteLine("|");
            });

            Console.WriteLine(bars);
        }

    }

}

