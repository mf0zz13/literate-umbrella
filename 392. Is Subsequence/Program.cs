namespace IsSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "axc";
            string t = "ahbgdc";

            Console.Write(IsSubsequence(s, t));
            Console.Read();
        }

        static bool IsSubsequence(string s, string t)
        {
            int sPos = 0;

            if (s.Length == 0)
                return true;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[sPos])
                    sPos += 1;

                if (sPos == s.Length)
                    return true;
            }

            return false;
        }
    }
}