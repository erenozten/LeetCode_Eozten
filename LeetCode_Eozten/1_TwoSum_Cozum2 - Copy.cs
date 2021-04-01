//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace LeetCode_Eozten
//{
//    public class Solution
//    {
//        static void Main()
//        {
//            int[] sampleArray = { 1, 7, 5, 3, 8, 10 };
//            int target = 18;

//            var watch = System.Diagnostics.Stopwatch.StartNew();
            
//            Solution program = new Solution();
//            int[] result = program.TwoSum(sampleArray, target);

//            watch.Stop();
//            var elapsedMs = watch.ElapsedMilliseconds;
//        }

//        public int[] TwoSum(int[] nums, int target)
//        {
//            int[] result = new int[] { -1, -1 };
//            if (nums == null)
//                return result;
//            if (nums.Length < 2)
//                return result;

//            Dictionary<int, int> map = new Dictionary<int, int>();

//            for (int i = 0; i < nums.Length; i++)
//            {
//                target = target - nums[i];
//                if (map.ContainsKey(target))
//                {
//                    result[0] = map[target];
//                    result[1] = i;
//                    return result;
//                }

//                //if duplicate number is present [it cannot be the solution]
//                if (map.ContainsKey(nums[i]))
//                    continue;
//                map.Add(nums[i], i);
//            }

//            return result;
//        }
//    }
//}