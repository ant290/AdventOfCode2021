using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent6
{
    internal class LanternFish
    {
        public int DaysToSpawn { get; set; }

        public LanternFish(int days)
        {
            DaysToSpawn = days;
        }

        public LanternFish Tick()
        {
            if (DaysToSpawn > 0)
            {
                DaysToSpawn--;
                return null;
            }

            DaysToSpawn = 6;
            return new LanternFish(8);
        }
    }
}
