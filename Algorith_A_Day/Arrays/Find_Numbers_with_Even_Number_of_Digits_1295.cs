﻿using System;
using System.Linq;

namespace Algorithm_A_Day.Arrays
{
    public class FindNumbersWithEvenNumberOfDigits1295
    {
        public static int FindNumbers(int[] nums)
        {
            if (nums.Length == 0 || nums == null) throw new Exception();
            return nums.Count(num => num.ToString().Length % 2 == 0);
        }

        //LINQ
        public int FindNumbers2(int[] nums)
        {
            return nums.Count(x => x.ToString().Length % 2 == 0);
        }

        // without string conversion
        public int FindNumbers3(int[] nums)
        {
            int evenCount = 0;
            int count = 0;
            int val = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                val = nums[i];
                while (val > 0) { count++; val = val / 10; }
                if (count % 2 == 0) { evenCount++; }
            }

            return evenCount;
        }

        //math with log
        // todo: understand
        /// <summary>
        /// Mathematical formula for counting digits in an int value is Math.Floor(Math.Log10(n) + 1))
        /// then instead of performing a % operation we can do a logical & with 1 in order to
        /// determine whether the number has even number of digits.
        /// </summary>

        public int FindNumbers4(int[] nums)
        {
            return nums.Count(x => x.ToString().Length % 2 == 0);
        }

    }
}

