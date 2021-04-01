//using System;

//namespace LeetCode_Eozten
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] sampleArray = { 1, 7, 5, 3, 8, 9 };
//            int target = 17;

//            var watch = System.Diagnostics.Stopwatch.StartNew();

//            Program program = new Program();
//            int[] result = program.TwoSum(sampleArray, target);

//            watch.Stop();
//            var elapsedMs = watch.ElapsedMilliseconds;
//            Console.WriteLine(elapsedMs);
//        }

//        public int[] TwoSum(int[] nums, int target)
//        {
//            //Input:    nums = [2, 7, 11, 15, 7], target = 14
//            //Output:          [0,1]

//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = 0; j < nums.Length; j++)
//                {
//                    if (i == j)
//                    {
//                        continue;
//                    }

//                    if (nums[i] + nums[j] == target)
//                    {
//                        var result = new[] { i, j };
//                        //var result = new int[] { i, j };

//                        return result;
//                    }
//                }
//            }
//            return new int[] { 0, 0 };
//        }
//    }
//}
