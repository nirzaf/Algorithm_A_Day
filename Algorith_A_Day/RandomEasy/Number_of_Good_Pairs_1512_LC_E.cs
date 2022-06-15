namespace Algorithm_A_Day.RandomEasy
{
    public class NumberOfGoodPairs1512LcE
    {
        public int NumIdenticalPairs(int[] nums)
        {
            if (nums.Length < 2) return 0;

            int goodPairs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j) goodPairs++;
                }
            }
            return goodPairs;
        }
    }
}
