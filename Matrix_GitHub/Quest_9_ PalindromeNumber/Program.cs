public class Solution
{
    public static void Main()
    {
        var number = 161;

        Solution solution = new Solution();
        var result = solution.IsPalindrome(number);
    }

    public bool IsPalindrome(int number)
    {
        if (number < 0)
        {
            return false;
        }

        var remainder = 0;
        var reversedNumber = 0;

        var nonEditedNumber = number;

        while (number > 0)
        {
            remainder = number % 10;
            number = number / 10;
            reversedNumber = reversedNumber * 10 + remainder;
        }

        if (reversedNumber == nonEditedNumber)
        {
            return true;
        }

        return false;
    }
}