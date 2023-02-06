using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
}



}
