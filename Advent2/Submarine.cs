using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2
{
    public class Submarine
    {
        private int _depth;
        private int _horizontal;
        private int _aim;

        public Submarine()
        {
            _depth = 0;
            _horizontal = 0;
            _aim = 0;
        }

        public void FollowInstruction(string instructionString)
        {
            var instruction = instructionString.Split(' ');
            int.TryParse(instruction[1], out var i);
            switch (instruction[0])
            {
                case "forward":
                    _horizontal += i;
                    _depth += _aim * i;
                    break;
                case "down":
                    _aim += i;
                    break;
                case "up":
                    _aim -= i;
                    break;
                default:
                    break;
            }
        }

        public int GetPositionsMultiplied()
        {
            return _depth * _horizontal;
        }
    }
}
