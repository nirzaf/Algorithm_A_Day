using Algorithm_A_Day.NodesModels;

namespace Algorithm_A_Day.RandomEasy
{
    //    The idea is to use start and end two indexes of the array to build a binary tree;
    //    The root node should be middle index of the array, since balanced binary search tree,
    //    make left subtree and right subtree same size or size difference minimum.
    public class ConvertSortedArrayToBstLc108E
    {
        public TreeNode SortedArrayToBst(int[] nums)
        {
            if (nums == null || nums.Length < 1) return null;

            return ConstructBsTfromArray(nums, 0, nums.Length - 1);
        }

        public TreeNode ConstructBsTfromArray(int[] nums, int left, int right)
        {
            if (left > right) return null;
            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = ConstructBsTfromArray(nums, left, mid - 1);
            root.right = ConstructBsTfromArray(nums, mid + 1, right);
            return root;
        }

        //JS 
        //var sortedArrayToBST = function(nums) {
        //    if (nums.length === 0) {
        //  return null
        //  }
        //  const middle = Math.floor(nums.length / 2)
        //  const root = new TreeNode(nums[middle])
        //  root.left = sortedArrayToBST(nums.slice(0, middle))
        //  root.right = sortedArrayToBST(nums.slice(middle + 1, nums.length))

        //  return root
        //}
    }
}
