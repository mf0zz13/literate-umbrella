using System;

namespace LeetCodeProblems
{
    class RemoveElement
    {
        static int RemoveElements(int[] nums, int val)
        {
            int count = 0;
            int position = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    int tempNum = nums[i];
                    nums[i] = nums[nums.Length - 1 - position];
                    nums[nums.Length - 1 - position] = tempNum;
                    position++;
                    count++;
                }
                if (nums[i] == val) { i--; count--; }
                if (i + position == nums.Length - 1) break;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;
            RemoveElements(nums, val);
        }
    }
}