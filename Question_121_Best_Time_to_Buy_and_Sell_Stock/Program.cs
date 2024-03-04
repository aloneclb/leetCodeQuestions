using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();


int[] prices = [7, 1, 5, 3, 6, 4];

var result = Solution.MaxProfit(prices);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);

public static class Solution
{
    public static int MaxProfit(int[]? prices)
    {
        if (prices == null || prices.Length < 2)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            int currentPrice = prices[i];
            int currentProfit = currentPrice - minPrice;
            maxProfit = Math.Max(maxProfit, currentProfit);
            minPrice = Math.Min(minPrice, currentPrice);
        }

        return maxProfit;
    }
}