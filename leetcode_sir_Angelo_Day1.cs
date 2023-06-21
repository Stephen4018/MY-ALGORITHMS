using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        //You are a product manager and currently leading a team to develop a new product.Unfortunately, thelatest version of your product fails the quality check.Since each version is developed based on the previous version, all the versions after a bad version are also bad. Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad. You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API. Input: n = 5, bad = 4
        //Output: 4
        //Explanation:
        //call isBadVersion(3) -> false
        //call isBadVersion(5) -> true
        //call isBadVersion(4) -> true
        //Then 4 is the first bad version.

        public int FirstBadVersion(int n)
        {
            return VersionFunction(1, n);
        }

        public static int VersionFunction(int first, int last)
        {
            while (first < last)
            {
                int median = first + (last - first) / 2;

                if (IsBadVersion(median))
                {
                    last = median;
                }
                else
                {
                    first = median + 1;
                }

            }
            return first;
        }

        public static bool IsBadVersion(int digit)
        {
            return true;
        }


        public static int SearchInsert(int[] nums, int target)
        {
            int start = nums[0];
            int end = nums[nums.Length - 1];

            while(start <= end)
            {
                double mid = start + (end - start) / 2;
                double ceils = Math.Ceiling(mid);
            }
            return 0;
        }
    }
}
