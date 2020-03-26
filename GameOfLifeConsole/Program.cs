using System;
using System.Collections.Generic;

namespace GameOfLifeConsole
{
    class Program
    {
        // static int tableWidth = 73;

        static void Main(string[] args)
        {
            World world = new World();
            Screen screen = new Screen(10, 10);
            world.RenderGrid(screen);
            world.Tick(screen);
            world.Tick(screen);
            world.Tick(screen);
            world.Tick(screen);
            world.Tick(screen);






            // Console.Clear();
            // PrintLine();
            // PrintRow("Column 1", "Column 2", "Column 3", "Column 4");
            // PrintLine();
            // PrintRow("", "", "", "");
            // PrintRow("", "", "", "");
            // PrintLine();
            // Console.ReadLine();
        }
    }
}










// public static void RenderGrid(Screen screen)
// {
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
// }









//         static void PrintLine()
//         {
//             Console.WriteLine(new string('-', tableWidth));
//         }

//         static void PrintRow(params string[] columns)
//         {
//             int width = (tableWidth - columns.Length) / columns.Length;
//             string row = "|";

//             foreach (string column in columns)
//             {
//                 row += AlignCentre(column, width) + "|";
//             }

//             Console.WriteLine(row);
//         }

//         static string AlignCentre(string text, int width)
//         {
//             text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

//             if (string.IsNullOrEmpty(text))
//             {
//                 return new string(' ', width);
//             }
//             else
//             {
//                 return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
//             }
//         }
//     }
// }

