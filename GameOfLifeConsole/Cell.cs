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
        public int LivingNeighbors { get; set; }
        public String PrintedValue
        {
            get
            {
                if (isAlive)
                {
                    return "|0|";
                }
                else
                {
                    return " ";
                };
            }
        }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            // if (this.LivingNeighbors < 2 || this.LivingNeighbors > 3)
            // {
            //     isAlive = false;
            // }
            // else if (this.LivingNeighbors == 3 && !isAlive)
            // {
            //     isAlive = true;
            // }
        }
    }
}
