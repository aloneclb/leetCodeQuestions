using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();


var result = Solution.MajorityElement([1, 2, 3, 4, 5, 5, 5, 5, 3, 3, 2, 2, 2, 1, 2]);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    public static int MajorityElement(int[] nums)
    {
        HashSet<int> myHashSet = new HashSet<int>(nums);
        var temp = 0;
        var number = 0;
        foreach (int num in myHashSet)
        {
            var numberCount = nums.Count(x => x == num);
            if (temp < numberCount)
            {
                temp = numberCount;
                number = num;
            }
        }

        return number;
    }
}