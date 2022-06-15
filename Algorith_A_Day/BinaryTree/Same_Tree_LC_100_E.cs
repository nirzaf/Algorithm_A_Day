using Algorithm_A_Day.NodesModels;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_A_Day.BinaryTree
{
    public class SameTreeLc100E
    {
        //Iterative Queue Approach(DFS)
        //T : O(Min(NodeCount))
        //S : O(Max(depth))
        bool IsValidSameValNode(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;
            else if (p.val != q.val)
                return false;
            else
                return true;
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            //for both empty
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            Stack<TreeNode> pStack = new Stack<TreeNode>();
            Stack<TreeNode> qStack = new Stack<TreeNode>();

            pStack.Push(p);
            qStack.Push(q);

            while (pStack.Count > 0 || qStack.Count > 0)
            {
                if (pStack.Count != qStack.Count)
                    return false;

                int size = pStack.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode curP = pStack.Pop();
                    TreeNode curQ = qStack.Pop();

                    if (IsValidSameValNode(curP, curQ) == false)
                        return false;

                    if (curP != null && curQ != null)
                    {
                        if (curP.left != null || curQ.left != null)
                        {
                            pStack.Push(curP.left);
                            qStack.Push(curQ.left);
                        }

                        if (curP.right != null || curQ.right != null)
                        {
                            pStack.Push(curP.right);
                            qStack.Push(curQ.right);
                        }
                    }
                }
            }
            return true;
        }

        //recursive
        public static bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            if (p.val == q.val)
            {
                return IsSameTree2(p.left, q.left) && IsSameTree2(p.right, q.right);
            }

            return false;
        }


        //JS
        //LOL
        //var isSameTree = function(p, q) {
        //    if(JSON.stringify(p)=== JSON.stringify(q)){
        //    return true;
        //    }
        //    else{
        //    return false
        //    }
        //}

        //recursive
        //        var isSameTree = function(p, q){
        //        if(!p)
        //                return q? false : true;
        //        if(!q)
        //                return false;
        //        if(p.val !== q.val)
        //                return false;
        //        if(!isSameTree(p.left, q.left))
        //                return false;
        //        return isSameTree(p.right, q.right);
        //      };
        //iterative
        //        var isSameTree = function(p, q) 
        //{
        //        var list1 =[p], list2 =[q];

        //        while(list1.length > 0)
        //        {
        //                if(list1.length !== list2.length)
        //                        return false;
        //                for(let i=list1.length-1; i>= 0; i--)
        //                {
        //                        if(!list1[i] && !list2[i])
        //                                continue;
        //                        if(!list1[i] || !list2[i])
        //                                return false;
        //                        if(list1[i].val !== list2[i].val)
        //                                return false;
        //                }

        //    let children1 =[], children2 =[];
        //    list1.forEach(el=>{if(el){children1.push(el.left);children1.push(el.right);}});
        //list2.forEach(el => { if (el) { children2.push(el.left); children2.push(el.right); } });
        //list1 = children1;
        //list2 = children2;
        //        }
        //        return true;
        //};
}
}
