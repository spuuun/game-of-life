using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfLifeConsole
{
    public class Screen
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<List<Cell>> Generation { get; set; }
    }
}
