
using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        var romanText = "MXLIV";
        Solution solution = new Solution();
        var result = solution.RomanToInt(romanText);
    }

    public static Dictionary<char, int> _dictionary = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string romanText)
    {
        if (romanText.Length <= 0)
        {
            throw new Exception();
        }

        var total = 0;
        var last = 0;

        foreach (var letter in romanText)
        {
            var currentLetterValue = TranslateToNumber(letter);

            if (currentLetterValue > last)
            {
                total -= last * 2;
            }

            total += currentLetterValue;
            last = currentLetterValue;
        }

        return total;
    }

    public static int TranslateToNumber(char c)
    {
        return _dictionary[c];
    }
}
