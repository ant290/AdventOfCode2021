using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent7
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = System.IO.File.ReadLines(@"data.txt");
            var crabs = new List<CrabMarine>();

            foreach (string input in inputs)
            {
                var startingCrabs = input.Split(',');
                foreach (string startingCrab in startingCrabs)
                {
                    Int32.TryParse(startingCrab, out var res);
                    crabs.Add(new CrabMarine(res));
                }
            }

            var maxPos = crabs.Max(x => x.Position);
            int? fuelUsed = null;

            for (int i = 0; i <= maxPos; i++)
            {
                var totalFuel = 0;
                //calculate fuel to get everyone to i
                foreach (CrabMarine crabMarine in crabs)
                {
                    totalFuel += crabMarine.costToMove(i);
                }

                if (fuelUsed == null || totalFuel < fuelUsed) fuelUsed = totalFuel;
            }

            Console.WriteLine(fuelUsed);
        }
    }
}
