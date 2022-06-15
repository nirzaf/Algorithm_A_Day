using System.Collections.Generic;
using System.Linq;

namespace Algorithm_A_Day.RandomEasy
{
    public class CreateOrder1389LcE
    {
        //unfinished wypociny 
        //public static int[] CreateTargetArray(int[] nums, int[] index)
        //{
        //    if (nums.Length != index.Length) return new int[] { };

        //    int[] target = new int[nums.Length];

        //    for (int j = 0; j < target.Length; j++)
        //    {
        //        target[j] = -1;
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (target[index[i]] != -1)
        //        {
        //            int[] temp = new int[nums.Length];
        //            for (int k = index[i] + 1; k < target.Length; k++)
        //            {
        //                temp[k] = target[k - 1];
        //            }
        //            temp[index[i]] = nums[i];
        //            target = temp;
        //        }
        //        else
        //        {
        //            target[index[i]] = nums[i];
        //        }

        //    }

        //    return target;

        //}

        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < index.Length; i++)
            {
                res.Insert(index[i], nums[i]);
            }
            return res.ToArray();
        }

        public static int[] CreateTargetArray2(int[] nums, int[] index)
        {

            var target = Enumerable.Repeat(101, nums.Length).ToArray();


            for (var i = 0; i < nums.Length; i++)
            {
                var index = index[i];

                var val = nums[i];

                if (target[index] == 101)
                    target[index] = val;
                else
                {
                    var tmp = target[index];

                    target[index] = val;

                    //TODO: (understand) write after some time
                    for (int start = index + 1; start < target.Length; start++)
                    {
                        var t2 = target[start];

                        target[start] = tmp;

                        tmp = t2;
                    }
                }
            }
            return target;

        }

        /*
          splice(start, deleteCount, item1)
          splice(start, deleteCount, item1, item2, itemN)
         var createTargetArray = function(nums, index) {
            const target = []
            for (let i=0;i<nums.length;i++){
                target.splice(index[i],0, nums[i]);//at index[i], delete 0 element and insert element nums[i]
            }
            return target
        };
         
         
         
         */
    }
}
