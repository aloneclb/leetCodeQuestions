using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine(3 ^ 5);

int[] prices = [2, 1, 2, 3, 3, 4, 4, 55, 1];

var result = Solution.SingleNumber(prices);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    // Hashsetlerde kullanılabilirdi
    
    public static int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }
    
    // XOR 
    // 0 XOR 0 = 0
    // 0 XOR 1 = 1
    // 1 XOR 0 = 1
    // 1 XOR 1 = 0
    
    // 0 1 1   -> 3 
    // 1 0 1   -> 5
//XOR--------------------
    // 1 1 0   -> 6
}