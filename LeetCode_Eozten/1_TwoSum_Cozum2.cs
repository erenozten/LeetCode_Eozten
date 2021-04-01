using System.Collections.Generic;

namespace LeetCode_Eozten
{
    public class Solution
    {
        static void Main()
        {
            int[] sampleArray = { 98, 5, 7, 92, 77, 66 };
            int target = 12;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Solution program = new Solution();
            int[] result = program.TwoSum(sampleArray, target);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            if (nums == null)
                return result;
            if (nums.Length < 2)
                return result;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //  -86      12     -   98
                //  7        12     -   5
                //  5        12     -   7
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    result[0] = map[diff];
                    result[1] = i;
                    return result;
                }

                //if duplicate number is present [it cannot be the solution]
                if (map.ContainsKey(nums[i]))
                    continue;
                map.Add(nums[i], i);
            }

            return result;
        }
    }
}
