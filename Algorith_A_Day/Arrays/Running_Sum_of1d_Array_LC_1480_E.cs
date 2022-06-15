namespace Algorithm_A_Day.Arrays
{
    public class RunningSumOf1dArrayLc1480E
    {
        public int[] RunningSum(int[] nums)
        {
            if (nums.Length == 0 || nums == null) return new int[] { };
            int len = nums.Length;

            for (int i = 1; i < len; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}