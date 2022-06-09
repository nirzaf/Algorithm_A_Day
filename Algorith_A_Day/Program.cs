﻿using Algorithm_A_Day.NodesModels;
using System;
using System.Collections.Generic;
using Algorithm_A_Day.RandomEasy;
using System.Collections;

namespace Algorith_A_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Queen", "Metallica", "Cream", "Oasis",
                "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Queen", "Madness", "Manic Street Preachers",
                "Noir Desir", "The Offspring", "Pink Floyd", "Oasis", "Rammstein", "Queen", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS", "Oasis" };

            TreeNode tree = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7, null, null), new TreeNode(2, null, null)), null),
                                new TreeNode(8, new TreeNode(13, null, null), new TreeNode(4, new TreeNode(5, null, null), new TreeNode(1, null, null))));
            TreeNode tree1 = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
            TreeNode tree2 = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
            //TreeNode tree2 = new TreeNode(1, null, new TreeNode(2, null, null));


            TreeNode tree3 = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));
            TreeNode tree4 = new TreeNode(2147483647, new TreeNode(2147483647, null, null), new TreeNode(2147483647, null, null));

            Node node1 = new Node(1, new Node(3, new Node(5, null, null), new Node(4, null, null)),
                                new Node(2, new Node(3, null, null), new Node(8, null, null)));
            // linked list
            ListNode x1 = new ListNode(1), x2 = new ListNode(2), x3 = new ListNode(3), x4 = new ListNode(4), x5 = new ListNode(5);
            x1.next = x2;
            x2.next = x3;
            x3.next = x4;
            x4.next = x5;

            ListNode y1 = new ListNode(1), y2 = new ListNode(3), y3 = new ListNode(4);
            y1.next = y2;
            y2.next = y3;

            ListNode z1 = new ListNode(2), z2 = new ListNode(6);
            z1.next = z2;

            var listOfLN = new ListNode[] { x1, y1, z1 };



            int[][] intervals = new int[4][];
            intervals[0] = new[] { 5, 8 };
            intervals[1] = new[] { 3, 9 };
            intervals[2] = new[] { 5, 12 };
            intervals[3] = new[] { 16, 5 };
            int[] r = new int[3];
            
            int[][] arrOfArrays = new int[4][];
            arrOfArrays[0] = new[] { 5, 1, 9, 11 };
            arrOfArrays[1] = new[] { 2, 4, 8, 10 };
            arrOfArrays[2] = new[] { 13, 3, 6, 7 };
            arrOfArrays[3] = new[] { 15, 14, 12, 16 };
            
            var arrOfArrays2 = new int[][]
            {
                new int[] { 1,  5,  9 },
                new int[] { 5, 6, 10 },
                new int[] { 12, 13, 15 }

            };

            // each array len must be the same
            int[,] TwoDArray = new int[3, 4] {
                { 1, 2, 3, 8 },
                { 4, 5, 6, 9 },
                { 7, 8, 9, 10 }
            };

            var x = new int[2];

            var z = 2.82842;
            int o = Convert.ToInt32(z);// rounds to 3 so 2.455->2  (no ceiling 2.1 -> 3)
            int p = (int)z; // it floors to 2


            var testArr = new int[] { 0, 0, 0 };
            var sortedArr = new int[] { 0, 1, 2, 2, 1 };
            var mixedArr = new int[] { 3, 2, 3 };
            var mixedArr2 = new string[] { "Hello", "Alaska", "Dad", "Peace" };
            var charA = new char[] { 'h', 'e', 'l', 'l', 'o' };

            

            //Self_Dividing_Numbers_LC_728_E.SelfDividingNumbers(1, 22);

            //Majority_Element_II_LC_229_M.MajorityElement(testArr);
            Number_of_Segments_in_a_String_LC_434_E.CountSegments("Of all the gin joints in all the towns in all the world,   ");
        }
        
        public static ListNode ReverseList(ListNode head)
        {
            IEnumerable x = new List<int>() { 1, 2, 3, 4, 5 };
            
            var y = x.GetEnumerator();
            while(y.MoveNext())
            {
                Console.WriteLine(y.Current);
            }
            return new ListNode();
        }
    }


}
