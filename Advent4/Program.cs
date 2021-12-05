using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file.
            var inputs = System.IO.File.ReadLines(@"data.txt");
            var draws = inputs.First();

            var boards = new List<Board>();
            Board board = null;

            //setup boards
            foreach (var item in inputs.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    if (board != null)
                    {
                        boards.Add(board);
                    }

                    //create a new board
                    board = new Board();
                }
                else
                {
                    board.SetRow(item);
                }
            }

            foreach (var item in draws.Split(','))
            {
                int.TryParse(item, out var i);

                // mark any boards
                boards.ForEach(x => x.TryMark(i));

                // check for winners
                var winners = boards.Where(x => x.CanScore()).ToList();

                if (winners.Count > 0)
                {
                    var res = winners.First().GetScore();
                    Console.WriteLine(res * i);
                    Console.ReadKey();
                }
            }
        }
    }
}
