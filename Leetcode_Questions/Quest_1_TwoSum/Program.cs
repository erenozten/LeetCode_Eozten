using System;
using System.Collections.Generic;

namespace Quest_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            int[] array = { 5, 7, 2, 6, 5, 1, 9 };
            int target = 10;

            Solution solution = new Solution();
            var result = solution.TwoSum(array, target);
        }

        public int[] TwoSum(int[] array, int target)
        {
            Dictionary<int, int> dictionary = new();

            var arrayLength = array.Length;

            if (arrayLength < 2 || array == null)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                var firstNumber = array[i];
                var secondNumber = target - firstNumber;

                if (dictionary.TryGetValue(secondNumber, out int secondNumberIndex))
                {
                    return new int[] { secondNumberIndex, i };
                }

                dictionary[firstNumber] = i;

            }
            return Array.Empty<int>();
        }
    }
}

