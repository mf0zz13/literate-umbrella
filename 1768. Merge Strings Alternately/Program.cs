using System.Text;

namespace MergeStringsAlternately
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";

            string returned = MergeAlternately(word1, word2);

            foreach (char character in returned)
            {
                Console.WriteLine(character);
            }

            Console.ReadKey();
        }

        public static string MergeAlternately(string word1, string word2)
        {
            int p1 = 0;
            int p2 = 0;
            int length = word1.Length + word2.Length;

            StringBuilder sb = new();


            for (int i = 0; i < length; i++)
            {
                if (p1 < word1.Length && p2 < word2.Length)
                {
                    sb.Append(word1[p1]);
                    sb.Append(word2[p2]);

                    p1 += 1;
                    p2 += 1;
                    i++;
                }
                else if (p1 == word1.Length)
                {
                    sb.Append(word2[p2]);
                    p2 += 1;
                }
                else
                {
                    sb.Append(word1[p1]);
                    p1 += 1;
                }
            }
            return sb.ToString();

        }
    }
}
