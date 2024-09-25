namespace FindTheHighestAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gain = { -5, 1, 5, 0, -7 };
            Console.Write(LargestAltitude(gain));
            Console.Read();
        }

        static int LargestAltitude(int[] gain)
        {
            int max = 0;
            int curr = 0;

            foreach (int num in gain)
            {
                curr += num;
                max = Math.Max(max, curr);
            }

            return max;
        }
    }
}