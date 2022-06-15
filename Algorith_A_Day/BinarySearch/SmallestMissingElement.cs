namespace Algorithm_A_Day.BinarySearch
{
    /// <summary>
    /// Goal: Find smallest missing element in arr where arr[i] == i, sorted and distinct non-negative
    /// [0,1,2,6,9,11,15] --> 3 
    /// [1,2,3,4,6,9,11,15] --> 0
    /// We can deduct that SME will be the index of first el which is not equal to its value. so arr[i] != i
    /// https://www.techiedelight.com/find-smallest-missing-element-sorted-array/
    /// </summary>
    public class SmallestMissingElement
    {
        //recursively
        public int SmallestMissingEl(int[] arr, int left, int right)
        {
            //base condition
            if (left > right) return left;
            int mid = left + (right - left) / 2;
            //if mid index is equal its element that means all left from mid is sorted
            //and there is no missing elements, SME must be on the right
            if(arr[mid] == mid)
            {
                return SmallestMissingEl(arr, mid + 1, right);
            }
            else //SME must be on left
            {
                return SmallestMissingEl(arr, left, mid - 1); 
            }
        }

        //iteratively
        public int SmallestMissingElIter(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right) 
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == mid)
                {
                    left =  mid + 1;
                }
                else //SME must be on left
                {
                    right =  mid - 1;
                }
            }
            return left;
        }
    }
}