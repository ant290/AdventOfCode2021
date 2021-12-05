using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent4
{
    public class Board
    {
        private List<List<BoardItem>> _grid;

        public Board()
        {
            _grid = new List<List<BoardItem>>();
        }

        public void SetRow(string numsStr)
        {

            var nums = numsStr.Split(' ');
            var row = new List<BoardItem>();
            foreach (var num in nums.Where(x => x.Length > 0))
            {
                int.TryParse(num, out var i);
                row.Add(new BoardItem(i));
            }
            _grid.Add(row);
        }

        public void TryMark(int i)
        {
            _grid.ForEach(x =>
            {
                x.ForEach(bi =>
                {
                    if (bi.Num == i) bi.Marked = true;
                });
            });
        }

        public bool CanScore()
        {
            if (_grid.Count < 1) return false;

            // either all in a row or all in a column
            if (_grid.Any(x => x.All(r => r.Marked))) return true;

            for (int i = 0; i < _grid.First().Count() - 1; i++)
            {
                if (_grid.All(x => x[i].Marked)) return true;
            }

            return false;
        }

        public int GetScore()
        {
            // sum of all unmarked numbers
            var res = 0;
            _grid.ForEach(x =>
            {
                x.ForEach(bi =>
                {
                    if (!bi.Marked) res += bi.Num;
                });
            });
            return res;
        }
    }

    public class BoardItem
    {
        public int Num;
        public bool Marked;

        public BoardItem(int num)
        {
            Num = num;
            Marked = false;
        }
    }
}
