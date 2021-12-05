using System;

namespace Advent2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sub = new Submarine();
            // Read the file line by line.  
            foreach (string line in System.IO.File.ReadLines(@"data.txt"))
            {
                sub.FollowInstruction(line);
            }

            Console.WriteLine(sub.GetPositionsMultiplied());
            Console.ReadKey();
        }
    }
}
