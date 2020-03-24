using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLife.Models
{
    public class Cell
    {
        public bool isAlive { get; set; }
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public List<Cell> LivingNeighbors { get; set; }
    }
}
