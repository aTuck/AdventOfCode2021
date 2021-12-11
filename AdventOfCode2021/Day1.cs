namespace AdventOfCode2021;

public class Day1 : IDay<int>
{
    private int Solve(List<int> input)
    {
        var count = 0;

        for (var i = 1; i < input.Count; i++)
        {
            if (input[i] > input[i - 1])
            {
                count++;
            }
        }

        return count;
    }

    public int Solve()
    {
        return Solve(Day1Input.data);
    }
}