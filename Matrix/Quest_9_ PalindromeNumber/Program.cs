// Çözümü inceledikten sonra kendim yapabildim. Ama unutulabilecek bir çözümü var. Tekrar çözülmeli.

/*
Runtime: 95 ms, faster than 11.11% of C# online submissions for Palindrome Number.
Memory Usage: 28.3 MB, less than 85.82% of C# online submissions for Palindrome Number.
*/


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

/*

    // Düşünelim ne yapıldığını:

        //reversedNumber değişkenine, gelen sayıyı olduğu gibi yazdık. Çünkü işlemler tamamlandığında, reversedNumber ile number YİNE birbirine eşit olmalı ki polindrome olayı doğru olmuş olsun. Birbirine eşit değilse: polindrome değildir sonucu çıkar.

    
    örnek sayı = 1024

    1 - Bu sayıyı 10 a bölüp kalanı buluyoruz. Bunu remainder değişkenine atıyoruz. yaptığımız işlem şu: remainder = number % 10;
    2 - 1024 sayısını 10 a bölüp kaça eşitse o sayıyı alıyoruz (102). yaptığımız işlem şu: number = number / 10;
    3 - kalanı 10 la çarpıp sonraki kalanı toplayıp değişkenen atıyoruz. (10 la çarpa çarpa basamakları elde etmiş oluyoruz. Birler onlar yüzler diye gidiyor. 10'la çarpılan bu sayıya da kalanı ekledikçe sayıyı tersten yazmış oluyor(muşu)z. Düşün.

*/


/*
 
    number = 1024 

    while döngüsüne gir:
    
    10 a böl kalanı al:    sonuç 4
    10 a böl, çıkan sonucu al. Çıkan sonuç 102. Bu sonucu metot içine gelen orijinal sayıya eşitle. yani:
    number = 102

    burda şimdi bi X sayısı var ve başlangıç değeri sıfır:

    x = x * 10 + kalan
    x = x * 10 + 4

    başlangıç değeri sıfır olduğuna göre ilk iterasyon sonunda:
    x = 4 
    sonucu çıkar.

    ikinci iterasyon:

    number 1024 e eşitti. Şimdi 102 ye eşit.
    (yani 10 a bölümünden 2 kalır)

    x = x * 10 + kalan
    x = 4 * 10 + 2
    x = 42

    Görüldüğü gibi sayı tersten yazılmaya başlanmış oldu... Bu şekilde gidiyor.

 */


// Çözümü inceledikten sonra kendi başıma yapabildim. Ama tekrar edilmesi gerekiyor. Unutulabilinecek bir çözüm.
// Değişken isimlerini anlaşılırlığı kolaylaştırabilmek için uzunca yazdım.
// ama leetcode'da parametre olarak int istiyor. Biz çözümde string kullandık. Aşağıda string li çözüm var. bi aşağıda da int li çözüm:


//public class Solution
//{
//    public static void Main()
//    {
//        var numberAsText = "161";

//        Solution solution = new Solution();
//        var result = solution.IsPalindrome(numberAsText);
//    }

//    public bool IsPalindrome(string numberAsText)
//    {
//        if (string.IsNullOrEmpty(numberAsText))
//        {
//            return false;
//        }

//        var remainder = 0;
//        var olusanYeniSayi = 0;

//        var numberAsInt = Convert.ToInt32(numberAsText);

//        var islemYapilmamisSayi = numberAsInt;

//        while (numberAsInt > 0)
//        {
//            remainder = numberAsInt % 10;
//            numberAsInt = numberAsInt / 10;
//            olusanYeniSayi = olusanYeniSayi * 10 + remainder;
//        }

//        if (olusanYeniSayi == islemYapilmamisSayi)
//        {
//            return true;
//        }

//        return false;
//    }
//}


/*
Runtime: 95 ms, faster than 11.11% of C# online submissions for Palindrome Number.
Memory Usage: 28.3 MB, less than 85.82% of C# online submissions for Palindrome Number.
*/

// parametresi int olan çözüm

//public class Solution
//{
//    public static void Main()
//    {
//        var number = 161;

//        Solution solution = new Solution();
//        var result = solution.IsPalindrome(number);
//    }

//    public bool IsPalindrome(int number)
//    {
//        if (number < 0)
//        {
//            return false;
//        }

//        var remainder = 0;
//        var olusanYeniSayi = 0;

//        var islemYapilmamisSayi = number;

//        while (number > 0)
//        {
//            remainder = number % 10;
//            number = number / 10;
//            olusanYeniSayi = olusanYeniSayi * 10 + remainder;
//        }

//        if (olusanYeniSayi == islemYapilmamisSayi)
//        {
//            return true;
//        }

//        return false;
//    }
//}


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