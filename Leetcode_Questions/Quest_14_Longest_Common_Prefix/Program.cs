
using System;

public class Solution
{
    public static void Main()
    {
        string[] array = new string[] { "fligg6", "flowerrrr11", "flo" };

        Solution solution = new Solution();
        var result = solution.LongestCommonPrefix(array);
    }

    public string LongestCommonPrefix(String[] strs)
    {
        var result = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].StartsWith(result) == false)
            {
                result = result.Substring(0, result.Length - 1);
            }
        }
        return result;
    }
}