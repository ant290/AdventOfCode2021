using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var windows = new List<SlidingWindow>();
            var workingWindows = new List<SlidingWindow> { };

            var counter = 0;

            // Read the file line by line.  
            foreach (string line in System.IO.File.ReadLines(@"data.txt"))
            {
                // create a single new window
                workingWindows.Add(new SlidingWindow());

                // set value on any existing windows
                int.TryParse(line, out var num);
                workingWindows.ForEach(x => x.AddData(num));

                // pop any full windows into the completed list
                var fullWindows = workingWindows.FindAll(x => x.IsFull());
                windows.AddRange(fullWindows);
                workingWindows.RemoveAll(x => x.IsFull());
            }

            SlidingWindow previousWindow = null;
            foreach(SlidingWindow win in windows)
            {

                if (previousWindow == null)
                {
                    previousWindow = win;
                    continue;
                }

                if (win.GetSum() > previousWindow.GetSum()) counter++;
                previousWindow = win;
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
