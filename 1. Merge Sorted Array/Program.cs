using System;

namespace LeetCodeProblems
{ 
    class MergeSortedArray
    {
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int counter = 0;

            for(int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[counter];
                counter++;
            }

            Array.Sort(nums1);
        }

        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;

            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            Merge(nums1, m, nums2, n);
        }
    }
}