namespace Algorithm_A_Day.Basics
{
    public class CollatzConjecture
    {
        public static int Collatz(int n)
        {
            if(n == 1) { return 0; }
            else if(n % 2 == 0)
            {
                return 1 + Collatz(n / 2);
            }
            else
            {
                return 1 + Collatz(3 * n  + 1);
            }
        }
        
        public static int CollatzIterativly(int n)
        {
            switch (n)
            {
                case 1:
                    return 0;
            }
            int counter = 0;
            while(n > 1)
            {
                switch (n % 2)
                {
                    case 0:
                        counter++;
                        n /= 2;
                        break;
                    default:
                        counter++;
                        n = n * 3 + 1;
                        break;
                }
            }
            return counter;
        }
    }
}
