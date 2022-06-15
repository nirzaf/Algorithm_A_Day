namespace Algorithm_A_Day.RandomEasy
{
    public class JewelsAndStonesLc771E
    {
        public int NumJewelsInStones(string j, string s)
        {
            if (j.Length == 0 || s.Length == 0) return 0;

            int result = 0;

            foreach (char j in j)
            {
                foreach (char s in s)
                {
                    if (j == s) result++;
                }
            }
            return result;
        }
    }
}
