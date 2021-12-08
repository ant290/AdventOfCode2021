// See https://aka.ms/new-console-template for more information
using Advent8;

var inputs = File.ReadLines(@"data.txt");

var displays = new List<SegmentDisplay>();
foreach (var item in inputs)
{
    displays.Add(new SegmentDisplay(item));
}

var counter = 0;
foreach (var item in displays)
{
    counter += item.timesHuntedDigitsAppear();
}

Console.WriteLine(counter);
Console.ReadKey();
