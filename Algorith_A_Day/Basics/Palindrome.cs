using System;

namespace Algorithm_A_Day.Basics
{
    class Palindrome
    {
        static bool IsWordPalindrome(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            return word.Length < 2 || IsPalidrome(0, word.Length - 1);

            bool IsPalidrome(int lo, int hi)
            {
                if (lo >= hi)
                    return true;

                if (char.ToUpperInvariant(word[lo]) !=
                    char.ToUpperInvariant(word[hi]))
                    return false;

                return IsPalidrome(lo + 1, hi - 1);
            }
        }
        
    }
}
