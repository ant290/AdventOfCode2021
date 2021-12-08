using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent8
{
    internal class SegmentDisplay
    {
        public string[] tenDigits { get; set; }
        public string[] fourDigits { get; set; }

        public SegmentDisplay(string input)
        {
            var data = input.Split('|');
            tenDigits = data[0].Trim().Split(' ');
            fourDigits = data[1].Trim().Split(' ');
        }

        public int timesHuntedDigitsAppear()
        {
            var counter = 0;
            foreach (var item in fourDigits)
            {
                switch (item.Length)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 7:
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            return counter;
        }
    }
}
