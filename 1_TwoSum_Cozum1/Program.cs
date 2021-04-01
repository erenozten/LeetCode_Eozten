//Çözüm 1
// kendi yaptığım çözüm. 

using System;

namespace LeetCode_Eozten
{
    class Program
    {
        static void Main()
        {

            int[] sampleArray = { 1, 7, 5, 3, 8, 9 };
            int target = 17;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Program program = new Program();
            int[] result = program.TwoSum(sampleArray, target);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            //Input:    nums = [2, 7, 11, 15, 7], target = 14
            //Output:          [0,1]

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        var result = new[] { i, j };
                        //var result = new int[] { i, j };

                        return result;
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}







////Çözüm 2
//// İnternetteki çözüme bakarak yapılan çözüm. Tekrar yapılacak.

//using System.Collections.Generic;

//namespace LeetCode_Eozten
//{
//    public class Solution
//    {
//        static void Main()
//        {

//            int[] sampleArray = { 98, 75, 75, 100, 50, 5, 7, 92, 77, 66 };
//            int target = 150;

//            // 75 + 75 = 150 olduğu halde bu iki değer dönülmemeli.
//            // Çünkü duplication olmamalı, soru böyle diyor.
//            // 75 + 75 = 150 olduğu halde bu sonuç yerine
//            // 100 + 50 = 150 sonucunu sağlayan index'ler return ediliyor.
//            // Yani kodumuz istenen şekilde çalışıyor.

//            Solution solution = new Solution();
//            var result = solution.TwoSum(sampleArray, target);
//        }

//        public int[] TwoSum(int[] nums, int target)
//        {
//            int[] result = { 0, 0 };

//            Dictionary<int, int> dictionary = new Dictionary<int, int>();

//            for (int i = 0; i < nums.Length; i++)
//            {
//                //   1        10         9
//                //   3        10         7
//                //.. 7        10         3
//                int gerekenSayi = target - nums[i];

//                if (dictionary.ContainsKey(gerekenSayi))
//                {
//                    result[0] = dictionary[gerekenSayi];
//                    result[1] = i;
//                }

//                if (dictionary.ContainsKey(nums[i]))
//                {
//                    continue;
//                    //yani duplication varsa bu aynı olan değeri
//                    //dictionary'e ekleme. döngünün sonraki
//                    //iterasyonuna geç.
//                }

//                dictionary.Add(nums[i], i);
//            }

//            return result;
//        }
//    }
//}






////Çözüm 3
//// internetteki çözüm

//using System.Collections.Generic;

//public class Solution
//{
//    public static void Main()
//    {
//    }

//    // https://leetcode.com/problems/two-sum/discuss/288073/c-solution-to-twosum-problem

//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] result = new int[] { -1, -1 };
//        if (nums == null)
//            return result;
//        if (nums.Length < 2)
//            return result;

//        System.Collections.Generic.Dictionary<int, int> map = new System.Collections.Generic.Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            int diff = target - nums[i];
//            if (map.ContainsKey(diff))
//            {
//                result[0] = map[diff];
//                result[1] = i;
//                return result;
//            }

//            //if duplicate number is present [it cannot be the solution]
//            if (map.ContainsKey(nums[i]))
//                continue;
//            map.Add(nums[i], i);
//        }
//        return result;
//    }
//}