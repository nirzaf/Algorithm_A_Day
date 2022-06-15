﻿using System.Collections.Generic;

namespace Algorithm_A_Day.Arrays.Arrays.Pramp
{
    /// <summary>
    /// Given an array arr of distinct integers and a nonnegative integer k,
    /// write a function findPairsWithGivenDifference that returns an array of all pairs [x,y] in arr,
    /// such that x - y = k. If no such pairs exist, return an empty array.
    /// Note: the order of the pairs in the output array should maintain the order of the y element in the original array.
    /// Examples:
    ///input:  arr = [0, -1, -2, 2, 1], k = 1
    ///output: [[1, 0], [0, -1], [-1, -2], [2, 1]]
    ///input:  arr = [1, 7, 5, 3, 32, 17, 12], k = 17
    ///output: []
    /// 
    /// </summary>
    class PairsWithSpecificDifferencePramp
    {
        //arr = [0, -1, -2, 2, 1]
        //brute force with tuples
        public static int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            var tempList = new List<(int, int)>();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //k = 3 j = 2 i = 5
                    //i = k + j
                    //k = i - j
                    //j = i - k


                    //arr[j] == arr[i] - k
                    if (k == arr[i] - arr[j] || k == arr[j] - arr[i])
                    {
                        var tuple = (arr[i], arr[j]);
                        if (!tempList.Contains(tuple) || !tempList.Contains((tuple.Item2, tuple.Item1)))
                        {
                            tempList.Add(tuple);
                        }
                    }
                }
            }

            var result = new int[tempList.Count, 2];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (j == 0) result[i, j] = tempList[i].Item1;
                    else result[i, j] = tempList[i].Item2;
                }

            }
            return result;
        }

        //with HashSet
        public static int[,] FindPairsWithGivenDifference2(int[] nums, int k)
        {
            if (k < 0)
                return null;
            var set = new HashSet<int>(nums);

            //allocate maximum space for arr
            var result = new int[nums.Length, 2];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (set.Contains(nums[i] + k))
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (j == 0) result[i, j] = nums[i];
                        else result[i, j] = nums[i] + k;
                    }
                }
            }

            return result;

            //int count = 0;
            //foreach (int val in set)
            //{
            //    0 + 1
            //    if (set.Contains(val + k))
            //        count++;

            //}
            //if (k == 0)
            //{
            //    return repeat.Count;
            //}
            //return count;
        }

        //dictionary
        // arr = [0, -1, -2, 2, 1], k = 1
        // here we rely on the fact that if k = x - y then y = x - k
        // Przetrzymujemy w dict wynik odejmowania k z danego elementu jako klucz i ten element jako wartosc 
        // czyli w dict mamy y jako klucz i x jako wartosc
        // co daje dict[y, x] y jako pierwsze poniewaz tak mowi tresc zadania mogloby byc x
        // 
        public static int[,] FindPairsWithGivenDifference3(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            //x - y = k  5 -3 = 2
            //x = k + y  5 = 2 + 3
            //y = x - k   3 = 5 -2   
            foreach (int item in nums)
            {
                dict.Add(item - k, item);
            }
            //0 - 1 , 0    [-1, 0]
            // -1 -1 , -1  [-2, -1] 
            // -2 -1, -2   [-3, -2]
            // 2 -1, 2     [1, 2]
            // 1 - 1, 1    [0, 1]
            var tempList = new List<int>();
            //var tempList2 = new List<int[]>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    //var tempArr = new int[2];
                    //tempArr[0] = dict[item];
                    //tempArr[0] = item;
                    //tempList2.Add(tempArr);
                    tempList.Add(dict[item]); //add x 
                    tempList.Add(item); //add y
                }
            }
            //return tempList2.ToArray();
            return Make2DArray(tempList, tempList.Count / 2, 2);

        }
        
        public static int[,] Make2DArray(List<int> input, int height, int width)
        {
            //to pass test
            if (input.Count == 0) return new int[0, 0];
            var arr = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = input[i * width + j];
                }
            }

            return arr;
        }


        //JS
        //    function findPairsWithGivenDifference(arr, k)
        //    {
        //        if (k == 0)
        //            return []


        //        map = { }
        //        answer = []


        //        for (let i = 0; i < arr.length; i++)
        //        {
        //            map[arr[i] - k] = arr[i];
        //        }
        //        console.log(map);
        //        for (let y = 0; y < arr.length; y++)
        //        {
        //            if (arr[y] in map){
        //            answer.push([map[arr[y]], Number(arr[y])])
        //  }
        //    }
        //    console.log(answer);   
        //return answer
        //}


        //brute force
        public static int[,] BindingFlags(int k, int[] arr)
        {
            var tempList = new List<int[]>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == k)
                    {
                        tempList.Add(new[] { arr[i], arr[j] });

                    }
                    else if (arr[j] - arr[i] == k)
                    {
                        tempList.Add(new[] { arr[j], arr[i] });
                    }
                }
            }
            var result = new int[tempList.Count, 2];
            int o = 0;
            foreach (var item in tempList)
            {
                result[o, 0] = item[0];
                result[o, 1] = item[1];

                o++;
            }
            //private static int[,] ConvertTo2DArray(List<int[]> list)
            //{
            //    var result = new int[list.Count(), 2];

            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            result[i, j] = list[i][j];
            //        }
            //    }

            //    return result;
            //}

            return result;
        }
    }
}
