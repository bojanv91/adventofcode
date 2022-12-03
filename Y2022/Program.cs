using BenchmarkDotNet.Running;
using Y2022;

//var summary = BenchmarkRunner.Run<MyBenchmark>();

//Console.WriteLine((int)'z' - 96);
//Console.WriteLine((int)'Z' - 38);
//return;

IDay day = new Day03();

Console.WriteLine(day.GetType().Name);
Console.WriteLine("Part 1");
Console.WriteLine(day.Part1());
Console.WriteLine("Part 2");
Console.WriteLine(day.Part2());
