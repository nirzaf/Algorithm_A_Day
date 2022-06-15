using System.Text;

namespace Algorithm_A_Day.RecursiveToDeal
{

    //todo: recursion to learn 
    public class IntToRomanLc12Recursion
    {
        public class Solution
        {
            public string IntToRoman(int num)
            {
                return GetRoman(num);
            }

            private string GetRoman(int num)
            {
                if (num >= 1000)
                {
                    return $"{GetRomanStr(num / 1000, 'M')}{GetRoman(num % 1000)}";
                }
                else if (num >= 500)
                {
                    string s = "D";
                    if (num >= 900)
                    {
                        s = "CM";
                        num = num - 400;
                    }
                    return $"{s}{GetRoman(num - 500)}";
                }
                else if (num >= 100)
                {
                    string s = num >= 400 ? "CD" : GetRomanStr(num / 100, 'C');
                    return $"{s}{GetRoman(num % 100)}";
                }
                else if (num >= 50)
                {
                    string s = "L";
                    if (num >= 90)
                    {
                        s = "XC";
                        num = num - 40;
                    }
                    return $"{s}{GetRoman(num - 50)}";
                }
                else if (num >= 10)
                {
                    string s = num >= 40 ? "XL" : GetRomanStr(num / 10, 'X');
                    return $"{s}{GetRoman(num % 10)}";
                }
                else if (num >= 5)
                {
                    string s = "V";
                    if (num >= 9)
                    {
                        s = "IX";
                        num = num - 4;
                    }
                    return $"{s}{GetRoman(num - 5)}";
                }
                else
                {
                    string s = num >= 4 ? "IV" : GetRomanStr(num, 'I');
                    return s;
                }
            }

            private string GetRomanStr(int num, char r)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < num; i++) sb.Append(r);
                return sb.ToString();
            }
        }
    }
}
