using System;
using System.Linq;

namespace Algorithm_A_Day.RandomEasy
{
    public class LengthOfLastWordLc58E
    {
        public static int LengthOfLastWord(string s)
        {
            var arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 0 || string.IsNullOrEmpty(s)) return 0;

            return arr[arr.Length - 1].Length;

        }
        public int LengthOfLastWord2(string s)
        {
            var n = s.Length;

            if (n == 0) return 0;

            var length = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    length++;
                }
                else
                {
                    if (length != 0)
                    {
                        break;
                    }
                }
            }

            return length;
        }

        //LINQ
        public int LengthOfLastWord3(string s)
        {
            return s.Trim().Split().LastOrDefault().Length;
        }
    }
}
