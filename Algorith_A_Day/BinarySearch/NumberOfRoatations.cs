﻿namespace Algorithm_A_Day.BinarySearch
{
    /// <summary>
    /// The problem is to find the number of rotation i circularly sorted array
    /// arr = [8, 9, 10, 2, 5, 6] is rotated 3 times, arr = [2,5,6,8,9,10] 0 times
    /// We can figure out that solution is index of minimum element
    /// linear search time complexity is O(n) binary search is O(log(n))
    /// https://www.techiedelight.com/find-number-rotations-circularly-sorted-array/
    /// solution: https://www.youtube.com/watch?v=4qjprDkJrjY&feature=emb_err_woyt
    /// PIVOT is element of rotated arr which starts the array it has special feature:
    /// both next and previous el. of to it is BIGGER than itself
    /// </summary>
    /// [8,9,10,2,5,6] pivot -2
    /// 10, 2, 5, 6, 8, 9 pivot 2 
    public class NumberOfRoatations
    {
        
        /// /// <summary>
        /// while loop works on values not indexes if arr[low] > arr[high] the array is rotated
        /// if arr[low] < arr[high] arr is NOT rotated
        /// Conditon 1. mid el. is bigger than far rigth one
        /// we change low for mid +1 [3, 4, 1, 2] 4>2 so low is 2 ( mid + 1) == [1,2]
        /// Conditon 2. mid el. is smaller than far rigth one
        /// we change high to mid [4, 5, 1, 2, 3] 1<3 so high is 2 ( hight = mid) == [4,5,1]
        /// </summary>
        /// <returns>low index(pivot element index)</returns>
        public int FindPivotIndex(int[] arr)
        {
            if (arr == null)
                return 0;
            int low = 0;
            int high = arr.Length - 1;
            while (arr[low] > arr[high])
            {
                // find mid.
                int mid = (low + high) / 2;
                // decide which sub-array to continue with.
                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }
            return low;
        }

        //harder elgo with next and prev elements(relating to index)
        public int NumberOfRotation(int[] nums)
        {
            //search space is nums[0 - len -1]
            int left = 0;
            int right = nums.Length - 1;

            //iterate till search space contains at-least one element
            while (left <= right)
            {

                //that means arr is sorted
                if (nums[left] <= nums[right])
                {
                    return left;
                }

                int mid = (left + right) / 2;
                // [8,9,10,2,5,6]
                //find next and prev element of the mid element
                //in circular manner 
                int next = (mid + 1) % nums.Length; //modulo here becuase if its the last element we need to go to the first el!!!!!!!
                int prev = (mid - 1 + nums.Length) % nums.Length; //+ len so its not negative number

                //if mid is less than both its next and prev neighbor, then it is the minimum of the arr
                //pivot element 2(index 3) is smaller than both next and prev that is its characteristic

                if (nums[mid] <= nums[next] &&
                    nums[mid] <= nums[prev])
                {
                    return mid;
                }

                //if arr[mid...right] is sorted and mid is not the min el,
                //the pivot el cannot be present in arr[mid..right] and 
                //we can discard arr[mid..right] and search in the left half

                else if (nums[mid] <= nums[right])
                {
                    right = mid - 1;
                }

                //if arr[left...mid] is sorted and pivot is not present in it, 
                //we can discard arr[left..mid] and search in the left half
                else if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        
    }
}
