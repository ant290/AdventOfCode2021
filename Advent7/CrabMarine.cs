using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent7
{
    public class CrabMarine
    {
        public int Position { get; set; }

        public CrabMarine(int position)
        {
            Position = position;
        }

        public int costToMove(int destination)
        {
            return Math.Abs(Position - destination);
        }
    }
}
