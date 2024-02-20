using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var input = "III";
var result = Solution.RomanToInt(input);
Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public static class Solution
{
    public static int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
        //special situations
        s = s.Replace("IV","IIII");
        s = s.Replace("IX","VIIII");
        s = s.Replace("XL","XXXX");
        s = s.Replace("XC","LXXXX");
        s = s.Replace("CD","CCCC");
        s = s.Replace("CM","DCCCC");

        var result = 0;
        
        foreach(var ch in s)
        {
            result += dict[ch];
        }
        
        return result;
    }
    
    public static int RomanToInt2(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
        char[] ch = s.ToCharArray();
    
        int result = 0;
        int intVal,nextIntVal;
            
        for(int i = 0; i <ch.Length ; i++){
            intVal = dict[ch[i]];
            
            if(i != ch.Length-1)
            {
                nextIntVal = dict[ch[i+1]];
                
                if(nextIntVal>intVal){
                    intVal = nextIntVal-intVal;
                    i = i+1;
                }
            }
            result += intVal;
        }
        return result;
    }
}