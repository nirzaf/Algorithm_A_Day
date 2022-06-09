using System;
using System.Collections.Generic;

namespace Algorithm_A_Day.Basics
{
    class Fibonacci
    {
        public static int Fib(int number)
        {
            //IT FINDS NTH FIBONACCI NUMBER
            if (number > 1) return Fib(number - 1) + Fib(number - 2);
            Console.WriteLine(number);
            return number;
        }


        public static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                //Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }

            if(counter == len)
            {
                Console.WriteLine(counter + "th number: {0}", a);
            }
        }

        //Fibonacci.Fibonacci_Rec_Temp(0, 1, 1, 6);
        // 0
        // Fibonacci.Fibonacci_Rec_Temp(1, 1, 2, 6);
        //1
        //  Fibonacci.Fibonacci_Rec_Temp(1, 2, 3, 6);
        //1
        // Fibonacci.Fibonacci_Rec_Temp(2, 3, 4, 6);
        //2
        // Fibonacci.Fibonacci_Rec_Temp(3, 5, 5, 6);
        //3
        // Fibonacci.Fibonacci_Rec_Temp(5, 8, 6, 6);
        //5

        //dp tabulation
        public static int FibTh_Iterativly(int number)
        {
            int[] arr = new int[number];

            arr[0] = 0;
            arr[1] = 1;

            for(int i = 2; i < number; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            foreach (int nummber in arr)
            {
                Console.WriteLine(nummber);
            }

            return arr[number - 1];
        }

        public static void FibDiffrently(int len)
        {
            int a = 0, b = 1, temp = 0;

            Console.Write("{0}, {1}, ", a, b);
            for(int i = 2; i <= len; i++)
            {
                temp = a + b;
                Console.Write("{0}, ", temp);
                a = b;
                b = temp;
            }
        }
        private static Dictionary<int, int> map = new Dictionary<int, int> { [0] = 0, [1] = 1 };

        public static int FibDPMemoization(int n)
        {

            if (map.ContainsKey(n))
            {
                return map[n];
            }
            else
            {
                map[n] = FibDPMemoization(n - 1) + FibDPMemoization(n - 2);
                //it must be return becuse otherwise that calls have no value
                return map[n];
            }
        }
        public static int FibDPTabulation(int n)
        {
            if (n == 0) return n;

            int[] result = new int[n];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i < n ; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result[n -1];
        }

        

        
    }
}
