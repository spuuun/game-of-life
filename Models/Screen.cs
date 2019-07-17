using System.Collections.Generic;

namespace GameOfLife
{
    public class Screen
    {
        // inherits grid properties from world class

        // an array of cells (from nextState method in world class)
        // maybe a list instead of an array
        List<Cell> allCells = new List<Cell>();

        // and passes them to a "print" method - essentially displaying the grid
    }
}