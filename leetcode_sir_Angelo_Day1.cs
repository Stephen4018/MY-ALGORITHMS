using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MY_ALGORITHMS
{
    public class leetcode_sir_Angelo_Day1
    {
        // Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.If target exists, then return its index.Otherwise, return -1.
        //You must write an algorithm with O(log n) runtime complexity.

        public int Search(int[] nums, int target)
        {
            return binarySearch(nums, 0, nums.Length - 1, target);
        }

        public int binarySearch(int[] nums, int start, int end, int target)
        {
            if (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    return binarySearch(nums, start, mid - 1, target);
                else
                    return binarySearch(nums, mid + 1, end, target);
            }
            return -1;
        }


       

       

      


      
        
    }
}
