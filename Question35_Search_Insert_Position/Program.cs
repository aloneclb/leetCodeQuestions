using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var input = new[] { 1, 3, 6, 6 };
var result = Solution.SearchInsert(input, 7);
Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        int i = 0;
        for (; i < nums.Length; i++)
        {
            if (target <= nums[i])
                return i;
        }

        return i;
    }
}