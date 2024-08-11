using System;

namespace LeetCodeProblems
{
    class MergeSortedArray
    {
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int place1 = m - 1;
            int place2 = n - 1;

            for (int i = (m + n) - 1; i >= 0; i--)
            {
                if (place2 < 0) break;

                if (place1 >= 0 && nums1[place1] > nums2[place2])
                {
                    nums1[i] = nums1[place1];
                    place1--;
                }
                else
                {
                    nums1[i] = nums2[place2];
                    place2--;

                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 2, 0 };
            int m = 1;

            int[] nums2 = new int[] { 1 };
            int n = 1;

            Merge(nums1, m, nums2, n);
        }
    }
}