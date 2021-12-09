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

        // details to work out which letter is which segment
        //if it's two characters, it must be a 1 so they must be top right and bottom right
        //if its three characters, it must be a 7 so they must be top, top right and bottom right
        //if its four characters, it must be a 4 so they must be top left, middle, top right and bottom right
        //if its seven characters, it must be a 8... they will all be on.

        //get the characters that appear in 1, 7 and not in 4.. that will give the top line
        //get the characters that 
    }
}
