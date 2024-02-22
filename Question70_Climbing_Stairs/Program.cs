using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var input = 7;
var result = Solution.ClimbStairs(input);
var result2 = Solution.ClimbingStairs(input);

Console.WriteLine(result);
Console.WriteLine(result2);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    public static int ClimbStairs(int n) {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
    
        // Her i adımı için, i-1 ve i-2 adımlardan gelen yolları topla
        for (int i = 2; i <= n; i++) {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
    
        // n adımını çıkmanın yollarını döndür
        return dp[n];
    }
    
    public static int ClimbingStairs(int n) {
        return Permute(n);
    }

    private static int Permute(int n) {
        if (n <= 1) {
            return 1;
        }
    
        return Permute(n - 1) + Permute(n - 2);
    }
}


// 5
// 1 + 1 + 1 + 1 + 1      - 1

// 2 + 1 + 1 + 1          - 2
// 1 + 2 + 1 + 1          - 3
// 1 + 1 + 2 + 1          - 4
// 1 + 1 + 1 + 2          - 5

// 2 + 2 + 1              - 6
// 2 + 1 + 2              - 7
// 1 + 2 + 2              - 8


// 4
// 1 + 1 + 1 + 1       - 1

// 2 + 1 + 1           - 2
// 1 + 2 + 1           - 3
// 1 + 1 + 2           - 4

// 2 + 2                -5




// 6
// 1 + 1 + 1 + 1 + 1 + 1     - 1

// 2 + 1 + 1 + 1 + 1            - 2
// 1 + 2 + 1 + 1 + 1            - 3
// 1 + 1 + 2 + 1 + 1            - 4
// 1 + 1 + 1 + 2 + 1            - 5
// 1 + 1 + 1 + 1 + 2            - 6

// 2 + 2 + 1 + 1                - 7
// 2 + 1 + 2 + 1                - 8
// 2 + 1 + 1 + 2                - 9
// 1 + 1 + 2 + 2                - 10
// 1 + 2 + 2 + 1                - 11
// 1 + 2 + 1 + 2                - 12

// 2 + 2 + 2                    - 13

