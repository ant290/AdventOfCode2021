// See https://aka.ms/new-console-template for more information
using Advent6;

var inputs = System.IO.File.ReadLines(@"data.txt");

var fishes = new List<LanternFish>();

foreach (var item in inputs)
{
    var startingFish = item.Split(',');
    foreach (var i in startingFish)
    {
        Int32.TryParse(i, out var res);
        fishes.Add(new LanternFish(res));
    }
}

// loop through 80 days
for (int i = 0; i < 256; i++)
{
    var todaysSpawns = new List<LanternFish>();
    foreach (var fish in fishes)
    {
        var res = fish.Tick();
        if (res != null) todaysSpawns.Add(res);
    }

    if (todaysSpawns.Count > 0)
    {
        fishes.AddRange(todaysSpawns);
    }
}

Console.WriteLine(fishes.Count);
