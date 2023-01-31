using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    public static void Main()
    {
        //Write a function that takes an integer as input, and returns the number of bits that are equal to one in the 
        //binary representation of that number. You can guarantee that input is non - negative.
        //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

        //SOLUTION**********
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

        //SOLUTION******************************
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


      
    }



}
