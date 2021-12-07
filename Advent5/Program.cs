using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file.
            var inputs = System.IO.File.ReadLines(@"data.txt");
            var vents = new List<Vent>();

            foreach (var item in inputs)
            {
                vents.Add(new Vent(item));
            }

            var largestX = Math.Max(vents.Max(x => x.startX), vents.Max(x => x.endX));
            var largestY = Math.Max(vents.Max(x => x.startY), vents.Max(y => y.endY));

            // get only horizontal or vertical lines
            var horizOrVertOnly = vents.Where(x => !x.IsDiagonal).ToList();

            // draw tha lines on to a grid with each line point incrementing the grid point by 1
            var grid = new int[largestX, largestY];

            foreach (var item in horizOrVertOnly)
            {
                Console.WriteLine($"Line {item.startX},{item.startY} -> {item.endX},{item.endY}");
                var coords = item.GetCoordinates();

                //walk the coords
                foreach (var coordinates in coords)
                {
                    grid[coordinates.X -1, coordinates.Y -1]++;
                }
            }

            // how many points are more then 2?
            var counter = 0;
            foreach (var item in grid)
            {
                if (item > 1) counter++;
            }

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
