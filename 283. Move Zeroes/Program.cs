namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 };

            MoveZeroes(nums);

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.Read();
        }

        static void MoveZeroes(int[] nums)
        {
            int writePos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                        break;
                    default:
                        nums[writePos] = nums[i];
                        writePos += 1;
                        break;
                }
            }

            for (int i = writePos; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}