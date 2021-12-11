using AdventOfCode2021;

var Problems = new List<IDay<int>>() { new Day1() };
var Solutions = Problems.Select(problem => problem.Solve()).ToList();

Solutions.ForEach(x => Console.WriteLine(x));