using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class SlidingWindow
    {
        private List<int> _numbers;

        public SlidingWindow()
        {
            _numbers = new List<int>();
        }

        public void AddData(int i)
        {
            _numbers.Add(i);
        }

        public bool IsFull()
        {
            return _numbers.Count == 3;
        }

        public int GetSum()
        {
            var res = 0;
            _numbers.ForEach(x => res = res + x);
            return res;
        }
    }
}
