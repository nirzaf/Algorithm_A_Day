﻿namespace Algorithm_A_Day.NodesModels
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public bool isVisited;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null, bool isVisited = false)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.isVisited = isVisited;
        }
    }
}
