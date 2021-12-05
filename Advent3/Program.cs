using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent3
{
    class Program
    {
        static void Main(string[] args)
        {
            //12bits
            // Read the file.
            var inputs = System.IO.File.ReadLines(@"data.txt");
            var oxInputs = new List<string>();
            var coInputs = new List<string>();
            foreach (var item in inputs)
            {
                oxInputs.Add(item);
                coInputs.Add(item);
            }

            //go through each column
            for (int i = 0; i < 12; i++)
            {
                //reset counts
                var oxOnCount = 0;
                var oxOffCount = 0;

                var coOnCount = 0;
                var coOffCount = 0;

                if (oxInputs.Count > 1)
                {
                    //go through each line
                    foreach (string line in oxInputs)
                    {
                        if (line[i] == '1')
                        {
                            oxOnCount++;
                        }
                        else
                        {
                            oxOffCount++;
                        }
                    }

                    //if off count larger, 0 else = 1
                    if (oxOnCount < oxOffCount)
                    {
                        // remove oxygens with 1
                        oxInputs.RemoveAll(x => x[i] == '1');
                    }
                    else
                    {
                        // remove oxygens with 0
                        oxInputs.RemoveAll(x => x[i] == '0');
                    }
                }


                if (coInputs.Count > 1)
                {
                    foreach (var line in coInputs)
                    {
                        if (line[i] == '1')
                        {
                            coOnCount++;
                        }
                        else
                        {
                            coOffCount++;
                        }
                    }

                    //if off count larger, 1 else = 0
                    if (coOffCount > coOnCount)
                    {
                        // remove carbons with 1
                        coInputs.RemoveAll(x => x[i] == '0');
                    }
                    else
                    {
                        // remove carbons with 0
                        coInputs.RemoveAll(x => x[i] == '1');
                    }
                }
            }

            var ox = Convert.ToInt32(oxInputs.First(), 2);
            var co = Convert.ToInt32(coInputs.First(), 2);

            Console.WriteLine(ox * co);
            Console.ReadKey();
        }
    }
}
