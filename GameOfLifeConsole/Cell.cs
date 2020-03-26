using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class Cell
    {
        public bool isAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Cell> LivingNeighbors { get; set; }
        public List<Cell> Neighbors { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
