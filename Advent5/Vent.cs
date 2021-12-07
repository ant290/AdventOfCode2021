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

        public IEnumerable<Coordinates> GetCoordinates()
        {
            var coords = new List<Coordinates>();
            if (startX == endX)
            {
                // walk the y coords
                var maxY = Math.Max(startY, endY);
                var minY = maxY == startY ? endY : startY;
                for (int i = minY ; i <= maxY; i++)
                {
                    coords.Add(new Coordinates
                    {
                        X = startX,
                        Y = i
                    });
                }
            }
            if (startY == endY)
            {
                // walk the x coords
                var maxX = Math.Max(startX, endX);
                var minX = maxX == startX ? endX : startX;
                for (int i = minX; i <= maxX; i++)
                {
                    coords.Add(new Coordinates
                    {
                        X = i,
                        Y = startY
                    });
                }
            }

            return coords;
        }
    }

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
