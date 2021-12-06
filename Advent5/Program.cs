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

            var largestX = vents.Max(x => x.startX);

            // get only horizontal or vertical lines
            var horizOrVertOnly = vents.Where(x => !x.IsDiagonal).ToList();

            // draw tha lines on to a grid with each line point incrementing the grid point by 1
            // var grid = new 


            foreach (var item in horizOrVertOnly)
            {
                Console.WriteLine($"Line {item.startX},{item.startY} -> {item.endX},{item.endY}");
            }

            Console.ReadKey();
        }
    }
}
