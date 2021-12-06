using System;
using System.Collections.Generic;
using System.Text;

namespace Advent5
{
    public class Vent
    {
        public int startX;
        public int startY;
        public int endX;
        public int endY;

        public Vent(string details)
        {
            details = details.Replace(" ", string.Empty);
            var coords = details.Split("->");

            //coords 0 = startx,starty
            var starts = coords[0].Split(',');
            Int32.TryParse(starts[0], out startX);
            Int32.TryParse(starts[1], out startY);

            //coords 1 = endx,endy
            var ends = coords[1].Split(',');
            Int32.TryParse(ends[0], out endX);
            Int32.TryParse(ends[1], out endY);
        }

        public bool IsDiagonal
        {
            get => startX != endX && startY != endY;
        }
    }
}
