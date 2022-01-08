/*
 Given an array of integers nums and an integer target, 
return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, 
and you may not use the same element twice.

You can return the answer in any order. 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

You may see this problem at Amazon, Autodesk, Vmware, Adobe, Paypal, Snap, Intercom, Tesla, Rubrik, Segment, Automattic, Grammarly, Intel, and Coupa.
https://leetcode.com/problems/two-sum/
 */








/*
// Yeni Çözüm
// Sen mi yaptın: Evet
// Çözüm başarılı mı: Evet
// Yardım alarak mı yaptın: Hayır
// Çözümün performanslı mı çalışıyor: Hayır (sitede yazan sonuca göre: diğerlerinden %79 daha hızlı)

// Runtime: 220 ms, faster than 79.02% of C# online submissions for Two Sum.
// Memory Usage: 42.4 MB, less than 8.36% of C# online submissions for Two Sum.

using System;
namespace Sol_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("1_Two_Sum");

            int[] arr = { 5, 9, 9, 9, 1 };
            int target = 10;

            Solution solution = new Solution();
            var result = solution.TwoSum(arr, target);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i <= numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        if (i != j)
                        {
                            //int[] returnArr = new int[2] { i, j };
                            //return new[] { i, j };

                            return new[] { i, j };
                        }
                    }
                }
            }
            return null;
        }
    }
}
*/






/*
// Yeni Çözüm
// Sen mi yaptın: Evet
// Çözüm başarılı mı: Evet
// Yardım alarak mı yaptın: Hayır
// Çözümün performanslı mı çalışıyor: Hayır (sitede yazan sonuca göre: diğerlerinden %79 daha hızlı)
// Notlar: Yaptığım ilk çözümden farkı: gereksiz parantezlerin silinmesi.

using System;
namespace Sol_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("1_Two_Sum");

            int[] arr = { 5, 7, 7, 9, 5, 8 };
            int target = 17;

            Solution solution = new Solution();
            var result = solution.TwoSum(arr, target);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i <= numbers.Length; i++)
                for (int j = 0; j < numbers.Length; j++)
                    if (numbers[i] + numbers[j] == target)
                        if (i != j)
                            return new[] { i, j };
            return null;
        }
    }
}
*/


/*
// Yeni Çözüm
// Sen mi yaptın: Hayır
// Çözüm başarılı mı: Evet
// Yardım alarak mı yaptın: -
// Çözüm performanslı mı çalışıyor: Biraz (sitede yazan sonuca göre: diğerlerinden %90 daha hızlı)
// Notlar: Kodu yazan kişi LINQ metodu kullanmış - nums.Count() - Fakat bunu kullanmak yerine
// for döngüsü içinde nums.Length yazarsak performans %1,5 kadar artıyor.
// Görünüşe göre LINQ kullanılmasaydı daha performanslı bir sonuç alınacaktı.
// Kodu yazan kişinin kodu aşağıda, onun altında ise benim modifiye ettiğim, %1.5 verimlilik
// sağlayan kod var.


using System;
using System.Linq;

namespace Sol_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("1_Two_Sum");

            int[] arr = { 5, 7, 7, 9, 5, 8 };
            int target = 17;

            Solution solution = new Solution();
            var result = solution.TwoSum(arr, target);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var count = nums.Count();
            for (var i = 0; i < count; i++)
                for (var j = i + 1; j < count; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }
        // T: O(n^2), where n is count of nums.
        // S: O(1), constant space.
    }
}
*/

/*
using System;
using System.Linq;

namespace Sol_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("1_Two_Sum");

            int[] arr = { 5, 7, 7, 9, 5, 8 };
            int target = 17;

            Solution solution = new Solution();
            var result = solution.TwoSum(arr, target);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            // aşağıda görüldüğü gibi LINQ kullanılmadan for döngüsü içinde Length (veya Count) bilgisi alındı.
            for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            return null;
        }
        // T: O(n^2), where n is count of nums.
        // S: O(1), constant space.
    }
}
*/



//süslü parantezler eklendi

//using System;
//using System.Linq;

//namespace Sol_1_TwoSum
//{
//    public class Solution
//    {
//        public static void Main()
//        {
//            Console.WriteLine("1_Two_Sum");

//            int[] arr = { 5, 7, 7, 9, 5, 8 };
//            int target = 17;

//            Solution solution = new Solution();
//            var result = solution.TwoSum(arr, target);
//        }

//        public int[] TwoSum(int[] nums, int target)
//        {
//            // aşağıda görüldüğü gibi LINQ kullanılmadan for döngüsü içinde Length (veya Count) bilgisi alındı.
//            for (var i = 0; i < nums.Length; i++)
//            {
//                for (var j = i + 1; j < nums.Length; j++)
//                {
//                    if (nums[i] + nums[j] == target)
//                        return new int[] { i, j };
//                }
//            }
//            return null;
//        }
//        // T: O(n^2), where n is count of nums.
//        // S: O(1), constant space.
//    }
//}










// Yeni Çözüm
// Sen mi yaptın: Hayır

//using System;

//namespace Sol_1_TwoSum
//{
//    public class Solution

//    {
//        static void Main()
//        {
//            Console.WriteLine("1_Two_Sum");

//            int[] arr = { 5, 3, 4, 2, 1, 0, 9 };
//            int target = 10;




//            Solution solution = new Solution();
//            var result = solution.TwoSum(arr, target);

//        }

//        public int[] TwoSum(int[] numbers, int target)
//        {
//            for (int i = 0; i <= numbers.Length; i++)
//            {
//                for (int j = 0; j < numbers.Length; j++)
//                {
//                    if (numbers[i] + numbers[j] == target)
//                    {
//                        if (i != j)
//                        {
//                            int[] returnArr = new int[2] { i, j };
//                            return returnArr;
//                        }
//                    }
//                }
//            }

//            return null;
//        }
//    }






























//    //class Program
//    //{
//    //    static void Main()
//    //    {

//    //        int[] sampleArray = { 1, 7, 5, 3, 8, 9 };
//    //        int target = 17;

//    //        var watch = System.Diagnostics.Stopwatch.StartNew();

//    //        Program program = new Program();
//    //        int[] result = program.TwoSum(sampleArray, target);

//    //        watch.Stop();
//    //        var elapsedMs = watch.ElapsedMilliseconds;
//    //        Console.WriteLine(elapsedMs);
//    //    }

//    //    public int[] TwoSum(int[] nums, int target)
//    //    {
//    //        //Input:    nums = [2, 7, 11, 15, 7], target = 14
//    //        //Output:          [0,1]

//    //        for (int i = 0; i < nums.Length; i++)
//    //        {
//    //            for (int j = 0; j < nums.Length; j++)
//    //            {
//    //                if (i == j)
//    //                {
//    //                    continue;
//    //                }

//    //                if (nums[i] + nums[j] == target)
//    //                {
//    //                    var result = new[] { i, j };
//    //                    //var result = new int[] { i, j };

//    //                    return result;
//    //                }
//    //            }
//    //        }
//    //        return new int[] { 0, 0 };
//    //    }
//    //}
//}







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



// 06/01/2022 tarihinde çözüldü. Mantığı anlaşıldı


/*
namespace Sol_1_TwoSum
{
    public class Solution
    {
        public static void Main()
        {
            int[] ornekArray = { 1, 2, 1, 2, 5, 6 };

            var returned = TwoSum(ornekArray, 7);
        }

        public static int[] TwoSum(int[] ornekArray, int target)
        {
            for (int i = 0; i <= ornekArray.Length; i++)
            {
                for (int j = 0; j < ornekArray.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (ornekArray[i] + ornekArray[j] == target)
                    {
                        return new int[] { i, j};

                    }
                }
            }

            return new int[3] { 1, 2, 3 };
        }
    }
}
*/



//// o(n) complexity çözüm:

////With this optimized approach we will have Time Complexity: O(n) since we are iterating the loop once and Space complexity would be O(n).

//// şurada çözüyor aşağıdaki gibi: 
//// https://www.c-sharpcorner.com/article/two-sum-leetcodes-solution-in-c-sharp-with-both-on-and-on2-approach/

//// kod debug edilerek çözüm anlaşıldı.
//// array'daki her bir değer için bir kez for döngüsünde dönülüyor toplamda. Yani array'da 10 değer varsa: döngüde 10 kez dönülüyor.
//// her dönüşte key value pair'leri dictionary'ye ekleniyor.

//// anlaşılması gereken nokta bundan sonra başlıyor:
//// for içinde dönerken, array'dan gelen sayı diyelim ki 5, target de 15. O halde bize gereken ilk sayı 5, ikinci sayı 10'dur.
//// for içinde dönerken, array'dan gelen sayıyı öncelikle dictionary'ye key (index) değeri ve value değeri şeklinde eklemiştik.
//// bize gereken ikinci sayı ne peki? Tabi ki hedef sayı - birinci sayı.
//// eğer bu Hedef sayı - Birinci sayı değerini dictionary içinde bulabilirsek (çünkü for döngüsünün her iterasyonunda dictionary'ye veri eklemiştik. Artık dictionary'miz boş değil ve içinde arama yapabiliriz!) sonuca ulaşabiliriz!
//// ikinci değeri dictionary içinde bulduğu anda: ilgili dictionary objesinin key dönmen gerekir. Amaç bu zaten. birinci sayıyla ikinci sayının indexlerini dönmek.


//// farklı anlatım:
//// hedef 15 olsun. Hedefi sağlayan sayılar: Birinci sayı 10, ikinci sayı 5 olsun.
//// birinci değer zaten array'dan alındı. Sana gereken sayı basit mantıkla: Target sayı - birinci sayı. Bu sayıya ikinci sayı diyelim.
//// hedef - birinci sayı = 15 - 10 = 5
//// Bulmamız gereken sayı 5 miş. 

//// belirttiğimiz üzere zaten birinci sayı array'dan alınıyor ve index değeriyle dictionary'ye ekleniyor. Bu her for iterasyonunda yapılıyor. Ve dictionary dolmuş oluyor.
//// senin şu an yapman gereken: ikinci sayıyı dictionary içinde aramak.
//// Eğer 5 sayısını dictionary içinde bulursan; o anki "i" değeri senin ikinci sayının index değeri olmuş olur. birinci sayının index değerini zaten o anki iterasyonun "i" değerinden elde ediyorsun.
//// bu iki değeri dönüyorsun ve finish.


//using System;
//using System.Collections.Generic;

//namespace Quest_1_TwoSum
//{
//    public class Solution
//    {
//        public static void Main()
//        {
//            int[] ornekArray = { 5, 7, 2, 6, 5, 1, 9 };

//            var returned = TwoSumOptimized(ornekArray, 14);
//        }

//        /// <summary>
//        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
//        /// </summary>
//        /// <param name="nums"></param>
//        /// <param name="target"></param>
//        /// <returns>integer array of indices</returns>
//        private static int[] TwoSumOptimized(int[] nums, int target)
//        {
//            //Declarations
//            int arrayLength = nums.Length;
//            Dictionary<int, int> resultDictionary = new();

//            //Validations
//            if (nums == null || arrayLength < 2)
//            {
//                return Array.Empty<int>();
//            }
//            //Logic
//            for (int i = 0; i < arrayLength; i++)
//            {
//                //int[] ornekArray = { 5, 7, 2, 6, 5, 1, 9 };

//                int firstNumber = nums[i]; // örneğe göre -> firstNumber = nums[0] = 5
//                int secondNumber = target - firstNumber; // örneğe göre -> secondNumber = 12 - nums[0] = 7 olması gerekir. Bu şart sağlanıyorsa işlem tamam.
//                if (resultDictionary.TryGetValue(secondNumber, out int index))
//                {
//                    return new[] { index, i };
//                }

//                /*resultDictionary.Add(firstNumber, i); */ //(hata veriyor.o yüzden aşağıdaki kullanılmış)

//                resultDictionary[firstNumber] = i;

//                // konuyla ilgisiz: aşağıdaki kod şu veriyi ekler dictionary'ye: [5,6]
//                //resultDictionary[5] = 6;

//                // aşağıdaki yazım şekli HATA VERİYOR! O yüzden o yazım kullanılmamış.

//                // konuyla ilgisiz: aşağıdaki kod şu veriyi ekler dictionary'ye: [7,8]
//                // ikisi aynı şey değil. Birisi hata veriyor, diğeri vermiyor.
//                //resultDictionary.Add(7, 8);

//                // konuyla ilgisiz:
//                // aşağıdaki gibi veri eklemek hata vermiyor. Çünkü aynı index'e ait olan bir veriyi sadece 1 kez ekliyor. Sonraki satırlarda yeni veri eklemiyor.
//                // bununla beraber, önceden eklenmiş olan bu index'in değerini güncelliyor!
//                //resultDictionary[5] = 8;
//                //resultDictionary[5] = 8;
//                //resultDictionary[5] = 8;
//                //resultDictionary[5] = 9;
//                //resultDictionary[5] = 10;
//            }
//            return Array.Empty<int>();
//        }
//    }
//}





//Yukarıdaki çözümün üzerinde hiç değişiklik yapılmamış hali. Siteden orijinal çözüm:

///// <summary>
///// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
///// </summary>
///// <param name="nums"></param>
///// <param name="target"></param>
///// <returns>integer array of indices</returns>
//private static int[] TwoSumOptimized(int[] nums, int target)
//{
//    //Declarations
//    int arrayLength = nums.Length;
//    Dictionary<int, int> resultDictionary = new();
//    //Validations
//    if (nums == null || arrayLength < 2)
//    {
//        return Array.Empty<int>();
//    }
//    //Logic
//    for (int i = 0; i < arrayLength; i++)
//    {
//        int firstNumber = nums[i];
//        int secondNumber = target - firstNumber;
//        if (resultDictionary.TryGetValue(secondNumber, out int index))
//        {
//            return new[] {
//                index,
//                i
//            };
//        }
//        //resultDictionary.Add(firstNumber, i);
//        resultDictionary[firstNumber] = i;
//    }
//    return Array.Empty<int>(); ;
//}


//// kendim çözdüm BAŞARILI sayılır (önce tabi çözümü inceledim. sonra bakmadan kendim yaptım)
//// kendim yaptım. Önce yapılışını inceledim. debug ettim. sonra en baştan kendim yazdım AMA bi yerde ufak bi hata yaptım
//// if() ten önce yazdım şunu ve hatalı sonuç döndü:  dictionary[firstNumber] = i;

// o if kısmını yanlış yazdığın zaman bazen doğru sonuç veriyo bazen yanlış. duplicate değerlerden bağımsız olarak böyle. Ayrıca leetcode kabul etmedi.

//namespace Quest_1_TwoSum
//{
//    public class Solution
//    {
//        public static void Main()
//        {
//            int[] ornekArray = { 3,2,4 };
//            //int[] ornekArray = { 5, 7, 2, 6, 5, 1, 9 };
//            int target = 6;

//            Solution solution = new Solution();
//            var result = solution.TwoSum(ornekArray, target);
//        }

//        public int[] TwoSum(int[] ornekArray, int target)
//        {
//            // aşağıdaki dictionary'ye her for iterasyonunda gelen değeri ve index'ini kaydedeceğiz key value şeklinde.
//            Dictionary<int, int> dictionary = new Dictionary<int, int>();

//            var arrayLength = ornekArray.Length;

//            if (arrayLength < 2 || ornekArray == null)
//            {
//                return null;
//            }

//            for (int i = 0; i < arrayLength; i++)
//            {
//                var firstNumber = ornekArray[i];
//                var secondNumber = target - firstNumber;

//                //if (firstNumber == secondNumber)
//                //{
//                //    continue;
//                //}

//                // Burada subtle bir olay var. Gizli ilginç bi olay: Dikkat edersen bu kodda "iki sayı birbirine eşitse alma" gibi bir check işlemi yapmıyoruz.
//                // yani if(firstNumber = secondNumber) ise, for döngüsünü continue; yapmalıyız. Çünkü bu istenmeyen bir durum! Yani:
//                // target = 6 ise; bizim array da {3,2,1} ise; bu if şartını koymazsan sonuç [0,0] döner. Çünkü 3+3 = 6 = target. Yani hedefi tutturdun ama iki ayrı sayıyla tutturmadın!
//                // bu yüzden if şartının olması gerekiyor. AMA! Bizim kodda yok ve yine de doğru çalışıyor!

//                // Sorun şöyle açıklanabilir: firstNumber ve secondNumber = 3 diyelim. target 6 olsun. TryGetValue den önce firstNumber'ı dictionary'ye eklersen
//                // TryGetValue çalıştığında bu 3 değerini tabi ki dictionary içinde bulur ve onu döner. Çünkü biraz önce ekledin! Yanlışlık burada.

//                //     dictionary[firstNumber] = i; kodunu if(dictionary.TryGetValue) den önce yazmışsan; bu haliyle kodun yanlış çalışır. Bu koda //if (firstNumber == secondNumber): continue;   şartını koyman gerekir
//                // ama dictionary[firstNumber] = i; kodunu if(dictionary.TryGetValue) den SONRA yazmışsan; o zaman if e gerek yok. Kodun çalışıyor.

//                if (dictionary.TryGetValue(secondNumber, out int ikinciSayininIndexi))
//                {
// aşağıdaki sıralama şu olmalı galiba: ikinciSayininIndexi, i (boylece örneğin [4,0] döneceğine [0,4] dönmüş oluyorsun. Çünkü "i" değeri şu anki iterasyonun indexini gösteriyor. Bu sayı doğal olarak ikinciSayininIndexi değerinden büyük olur (tam düşünmedim ama öyle olmalı). O yüzden sıralama böyle olmalı. Tersini yazarsan tam doğru olmaz. Çünkü [4,0] döner. İstenen sonuçlar ise hep önce küçük sayı, sonra büyük sayı şeklinde.
//                    return new int[] { ikinciSayininIndexi, i };
//                }

//                // no 33 // aşağıdaki: firstNumber'ı sola yazmalı (önemli bu), index ini sağa yazmalı. Yoksa nasıl TryGetValue'yi çalıştıralım. Bu metot key'e göre arama yapıyor. o halde toplama işlemine dahil olacak olan firstNumber'i key değerine (sol tarafa) atamak gerek.
//                dictionary[firstNumber] = i;

//            }
//            return null;
//        }
//    }
//}




//bi üstteki çözümümün değişken adları değiştirilip comment ler silinip Leetcode'a atılmış şekli. Amaç: sitedeki Like sayısını artırmak

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



//public class Solution
//{
//    public static void Main()
//    {
//        int[] array = new int[4] { 1, 2, 3, 4 };
//        Solution solution = new Solution();
//        var result = solution.TwoSum(array, 7);
//    }

//    public int[] TwoSum(int[] array, int target)
//    {
//        Dictionary<int, int> dictionary = new();

//        for (int i = 0; i < array.Length; i++)
//        {

//        }


//        return null;
//    }
//}