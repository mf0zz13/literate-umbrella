namespace FindPivotIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, -1, 0, 1, 1, 0 };

            Console.Write(PivotIndex(nums));
            Console.Read();
        }

        static int PivotIndex(int[] nums)
        {
            int rightSum = nums.Sum();
            int leftSum = 0;

            if (nums.Length == 1)
                return 0;

            rightSum -= nums[0];
            if (rightSum == 0)
                return 0;

            for (int i = 1; i < nums.Length; i++)
            {
                leftSum += nums[i - 1];
                rightSum -= nums[i];
                if (leftSum == rightSum)
                    return i;
            }
            return -1;
        }
    }
}