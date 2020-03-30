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
                    return "|X";
                }
                else
                {
                    return "|-";
                };
            }
        }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            LivingNeighbors = 0;
        }

        public void Tick()
        {
            if ((this.LivingNeighbors < 2 || this.LivingNeighbors > 3) && this.isAlive)
            {
                this.isAlive = false;
            }
            else if (this.LivingNeighbors == 3 && !this.isAlive)
            {
                this.isAlive = true;
            }
            else
            {
                this.isAlive = this.isAlive;
            }
        }
        public void ClearNeighbors()
        {
            // clear number of living neighbors before next gen.
            LivingNeighbors = 0;
        }
    }
}
