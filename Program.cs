using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void Main()
    {
        //Write a function that takes an integer as input, and returns the number of bits that are equal to one in the 
        //binary representation of that number. You can guarantee that input is non - negative.
        //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

        //SOLUTION*************************************************************
        //        using System;
        //        using System.Linq;

        //public class Kata
        //    {
        //        public static int CountBits(int n)
        //        {
        //            return Convert.ToString(n, 2).Count(x => x == '1');
        //        }
        //    }
        //*********************************************************************************************************



        //THIS IS A SOLUTION TO JAVASCRIPT FIBONACCHI CHALLELNGE, DO NOT RUN THIS CODE ON THIS IDE
        //        const fibo = (num, count) => {
        //            const data = [];
        //            data.push(num, num);
        //            let zero = 0;
        //            let one = 1;

        //            for (let i = 2; i < count; i++)
        //            {
        //                data[i] = data[zero] + data[one]
        //               zero++
        //               one++
        //            }
        //            console.log(...data)
        //}



        //In this kata you get the start number and the end number of a region and should return the count of all numbers except 
        //numbers with a 5 in it.The start and the end number are both inclusive!
        //1,9-> 1,2,3,4,6,7,8,9-> Result 8
        //4,17-> 4,6,7,8,9,10,11,12,13,14,16,17-> Result 12

        //SOLUTION************************************************************
        //        public class Kata
        //{
        //    public static int DontGiveMeFive(int start, int end)
        //  {
        //      int count = 0;
        //      for(int i = start; i <= end ; i++)
        //      {
        //          string fix = i.ToString();
        //         if(!fix.Contains("5"))
        //         {
        //             count++;
        //         }

        //      }
        //      return count;
        //  }
        //}



        //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        //    Input: nums1 = [1, 3], nums2 = [2]
        //    Output: 2.00000
        //    Explanation: merged array = [1, 2, 3] and median is 2.

        //SOLUTION*******************************************************
        //public class Solutions
        //  {
        //      public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //      {

        //          int[] combined = nums1.Concat(nums2).ToArray();
        //          Array.Sort(combined);
        //          if (combined.Length % 2 == 0)
        //          {
        //              int first = combined.Length / 2;
        //              int second = (combined.Length / 2) - 1;
        //              double median = (combined[first] + combined[second]) / 2;
        //              if (median == 0)
        //              {
        //                  return median;
        //              }
        //              if ((combined[first] + combined[second]) % 2 == 0)
        //              {
        //                  return median;
        //              }
        //              else
        //              {
        //                  return Convert.ToDouble(median + 0.5);

        //              }

        //          }
        //          else
        //          {
        //              int index = (combined.Length - 1) / 2;
        //              return combined[index];
        //          }

        //      }
        //  }




        //You are given an array(which will have a length of at least 3, but could be very large) containing integers. 
        //The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
        // Write a method that takes the array as an argument and returns this "outlier" N.
        // [2, 4, 0, 100, 4, 11, 2602, 36]
        // Should return: 11(the only odd number)
        //[160, 3, 1719, 19, 11, 13, -21]
        //Should return: 160(the only even number)

        //SOLUTION********************************************************************
        //using System.Linq;

        //public class Kata
        // {
        //public static int Find(int[] integers)
        //{
        //    var evenNumbers = integers.Where(integer => integer % 2 == 0).ToArray();
        //    var oddNumbers = integers.Where(integer => integer % 2 == 1).ToArray();
        //    return evenNumbers.Length > oddNumbers.Length ? oddNumbers[0] : evenNumbers[0];
        //}
        // }


        //In this Kata, you will be given two strings a and b and your task will be to return the characters that are not common in the two strings.solve("xyab", "xzca") = "ybzc"

        //SOLUTION********************************************************************************

        //string check = string.Concat(a, b);

        //List<char> strings = new List<char>();



        //foreach (char alph in check)
        //{
        //    if (!a.Contains(alph) || !b.Contains(alph))
        //    {
        //        strings.Add(alph);
        //        // Console.WriteLine("hello");
        //    }

        //}

        //Console.WriteLine(a + b);
        //Console.WriteLine(string.Join("", strings));


        //The Fibonacci numbers are the numbers in the following integer sequence(Fn):
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
        //productFib(714) # should return (21, 34, true), 
        //# since F(8) = 21, F(9) = 34 and 714 = 21 * 34.................
        //productFib(800) # should return (34, 55, false), 
        //# since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55

        //SOLUTION******************************************************************************

        //        using System;
        //        using System.Linq;
        //        using System.Collections.Generic;

        //public class ProdFib
        //    {
        //        public static ulong[] productFib(ulong prod)
        //        {

        //            List<ulong> fibo = new List<ulong>();

        //            List<ulong> nums = new List<ulong>();
        //            nums.Add(0);
        //            nums.Add(1);
        //            for (int i = 0; i < 50; i++)
        //            {
        //                nums.Add(nums[i] + nums[i + 1]);
        //            }

        //            for (int i = 0; i < nums.Count; i++)
        //            {
        //                if ((nums[i] * nums[i + 1]) == prod)
        //                {
        //                    fibo.Add(nums[i]);
        //                    fibo.Add(nums[i + 1]);
        //                    fibo.Add(1);
        //                    break;
        //                }

        //                if ((nums[i] * nums[i + 1]) > prod)
        //                {
        //                    fibo.Add(nums[i]);
        //                    fibo.Add(nums[i + 1]);
        //                    fibo.Add(0);
        //                    break;
        //                }

        //            }
        //            return fibo.ToArray();
        //        }
        //    }

        //**************************************************
        int[] userAge = new int[5];
        userAge = new[] { 21, 22, 23, 24, 25 };
        //Array.Sort(userAge);
        userAge.OrderByDescending(num => num);
        int sum = userAge.Aggregate((a, b) => a - b); //this aggregate works like reduce in javascript
        //Console.WriteLine(sum);



        //Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.
        //Your task is to write a function maskify, which changes all but the last four characters into '#'.
        //Examples
        //"4556364607935616"-- > "############5616"
        // "64607935616"-- > "#######5616"
        //SOLUTION**************************************************************************************
        string letter = "Nananananananananananananananana Batman!";
        char[] charArray = letter.ToCharArray();
        string prints = "";
        if (letter.Length > 4)
        {
            for (int i = 0; i < charArray.Length - 4; i++)
            {
                prints += '#';
            }
            //Console.WriteLine(prints + letter.Substring(letter.Length - 4));

        }
        else
        {
            //Console.WriteLine(letter);
        }

        //string h = "hello";
        //string g = h.PadLeft(15, '#');
        //Console.WriteLine(g);



        //Finish the function numberToOrdinal, which should take a number and return it as a string with the correct ordinal indicator suffix(in English).That is:
        //numberToOrdinal(1) ==> '1st'
        //numberToOrdinal(2) ==> '2nd'
        //SOLUTION*************************************************************************


        int n = 1000;
        if (n == 0) Console.WriteLine("0");
        int num = n % 10;
        string ns = n.ToString();
        int two = int.Parse(ns.Substring(ns.Length - 2));

        string suffix = "th";

        if (num == 1 && two != 11)
        {
            suffix = "st";
        }
        else if (num == 2 && two != 12)
        {
            suffix = "nd";
        }
        else if (num == 3 && two != 13)
        {
            suffix = "rd";
        }

       //Console.WriteLine(n.ToString() + suffix);
    


        string word = "Hey fellow warriors";
        string[] newWord = word.Split(' ');
        //List<char> words = new List<char>();
        //var check = newWord.Select(x => x.Length >= 5 ? x.Reverse() : x);
        for (int i = 0; i < newWord.Length; i++)
        {
            char[] one = newWord[i].ToCharArray();
            if (newWord[i].Length >= 5)
            {
                newWord[i].Reverse();
            }
        }
        //Console.WriteLine(string.Join(" ", newWord));





        //List<int> num = new List<int> { 0, 9, 9, 3 };
        //char[] myArray = new char[] { '0' };
        //char[] digit = (int.Parse(string.Join("", num)) + 1).ToString().ToCharArray();


        //foreach (int i in num)
        //{
        //    if(i < 0 || i.ToString().Length > 1)
        //    {
        //        //Console.WriteLine("null");
        //    }
        //}


        //if (num[0] == 0 && num[num.Count - 1] != 9) 
        //{
        //    char[] resultArray = myArray.Concat(digit).ToArray();
        //    //Console.WriteLine(string.Join(" ", resultArray));
        //}
        //else
        //{
        //    //Console.WriteLine(string.Join(", ", digit));
        //}

        //Console.WriteLine(num[0] );
        //

        //Poker Chips: Luigy works in a Casino and he gives customers poker chips in exchange of money.Find the minimum number of chips Luigy can use to match the customer requests. He has chips worth 100, 50, 25, 10, 5, 1.For example, for 126 Luigy should give 3 chips(100, 25, 1).
        
        int nums = 226;
        int count = 0;
        while (nums >= 100)
        {
            nums = nums - 100;
            count++;
        }
        while (nums >= 50)
        {
            nums = nums - 50;
            count++;
        }
        while (nums >= 25)
        {
            nums = nums - 25;
            count++;
        }
        while (nums >= 10)
        {
            nums = nums - 10;
            count++;
        }
        while (nums >= 5)
        {
            nums = nums - 5;
            count++;
        }
        while (nums >= 1)
        {
            nums = nums - 25;
            count++;
        }
        //Console.WriteLine();



//        Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.
//Example
//"abcde"-> 0 # no characters repeats more than once
//"aabbcde"-> 2 # 'a' and 'b'
//"aabBcde"-> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility"-> 1 # 'i' occurs six times
//"Indivisibilities"-> 2 # 'i' occurs seven times and 's' occurs twice
//"aA11"-> 2 # 'a' and '1'
//"ABBA"-> 2 # 'A' and 'B' each occur twice

        HashSet<char> words = new HashSet<char>();
        string str = "aabbcde";
        string newStr = str.ToLower();
        char[] chars = newStr.ToCharArray();
        Array.Sort(chars);
        int counts = 0;

        for(int i = 0; i < chars.Length-1;i++)
        {
            if (chars[i] == chars[i + 1])
            {
                words.Add(chars[i]);
            }
        }
        //Console.WriteLine(words.Count);


        //anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

        string wordina = "abba";

        string[] arr = { "aabb", "abcd", "bbaa", "dada" };









    }
}




