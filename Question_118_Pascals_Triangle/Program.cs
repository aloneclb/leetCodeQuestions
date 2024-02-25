using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();


var result = Solution.Generate(3);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>>();
        if (numRows == 0)
            return list;

        list.Add([1]);

        if (numRows == 1)
            return list;

        list.Add([1, 1]);

        for (int i = 2; i < numRows; i++)
        {
            list.Add(new List<int>());
            list[i].Add(1);

            for (int inner = 0; inner < list[i - 1].Count; inner++)
            {
                if (inner + 1 == list[i - 1].Count)
                    break;
                list[i].Add(list[i - 1][inner] + list[i - 1][inner + 1]);
            }

            list[i].Add(1);
        }

        return list;
    }
}