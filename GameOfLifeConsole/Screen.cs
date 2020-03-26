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
        public Screen()
        {
            var width = Width;
            var height = Height;
            var screen0 = new Screen();

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    screen0[y][x] = new Cell();
                }
            }
        }

    }
}
