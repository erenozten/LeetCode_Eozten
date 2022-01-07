
/*

https://leetcode.com/problems/palindrome-number/

Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward.

For example, 121 is a palindrome while 123 is not.
 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left.Therefore it is not a palindrome.

*/


//sayı pozitif olmalı. negatif olursa sayının başında "-" olacağı için palindrom olmaz.,

//public class Solution
//{
//    public static void Main()
//    {
//        Console.WriteLine("Quest_9_ PalindromeNumber \n");
//        Solution solution = new Solution();

//        int number = 12321;
//        var result = solution.IsPalindrome(number);
//    }

//    public bool IsPalindrome(int number)
//    {

//        return false;
//    }
//}



//public class Solution
//{
//    static void Main()
//    {
//        string numberAsText = "1024";

//        Solution solution = new Solution();
//        var result = solution.IsPalindrome(numberAsText);
//    }

//    public bool IsPalindrome(string numberAsText)
//    {
//        int islemYapilmisHali, remainder, sum = 0, islemYapilmamisHali;
//        //clrscr();   

//        islemYapilmisHali = Convert.ToInt32(numberAsText);

//        //islemYapilmamisHali değişkenine, gelen sayıyı olduğu gibi yazdık. Çünkü işlemler tamamlandığında, islemYapilmamisHali ile islemYapilmisHali YİNE birbirine eşit olmalı ki polindrome olayı doğru olmuş olsun. Birbirine eşit değilse: polindrome değildir sonucu çıkar.
//        islemYapilmamisHali = islemYapilmisHali;

//        while (islemYapilmisHali > 0)
//        {
//            remainder = islemYapilmisHali % 10; //for getting remainder by dividing with 10    
//            islemYapilmisHali = islemYapilmisHali / 10; //for getting quotient by dividing with 10    
//            sum = sum * 10 + remainder;
//            /*multiplying the sum with 10 and adding  
//            remainder*/
//        }
//        Console.WriteLine("\nThe Reversed Number is: {0} \n", sum);

//        if (islemYapilmamisHali == sum) //checking whether the reversed number is equal to entered number    
//        {
//            Console.WriteLine("True!");
//            return true;
//        }
//        else
//        {
//            Console.WriteLine("False!");
//            return false;
//        }
//    }
//}



