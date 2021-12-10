// See https://aka.ms/new-console-template for more information

var inputs = File.ReadLines(@"data.txt");

var linesArr = inputs.ToArray();
var maxWidth = linesArr[0].Length -1;
var maxHeight = linesArr.Length -1;

var lowPoints = new List<int>();

for (int y = 0; y < linesArr.Length; y++)
{
    for (int i = 0; i <= maxWidth; i++)
    {
        //get adjacent points to line[i]
        var points = new List<int>();
        //above
        if (y > 0)
        {
            var above = int.Parse(linesArr[y - 1][i].ToString());
            points.Add(above);
        }
        //right
        if (i < maxWidth)
        {
            var right = int.Parse(linesArr[y][i + 1].ToString());
            points.Add(right);
        }
        //below
        if (y < maxHeight)
        {
            var below = int.Parse(linesArr[y + 1][i].ToString());
            points.Add(below);
        }
        //left
        if (i > 0)
        {
            var left = int.Parse(linesArr[y][i - 1].ToString());
            points.Add(left);
        }

        //if line[i] is lowest add to lowPoints
        var centre = int.Parse(linesArr[y][i].ToString());
        if (!points.Any(x => x <= centre))
        {
            lowPoints.Add(int.Parse(linesArr[y][i].ToString()));
        }
    }
}

var totalRisk = 0;

foreach (var item in lowPoints)
{
    var risk = 1 + item;
    totalRisk += risk;
}

Console.WriteLine(totalRisk);
Console.ReadKey();
