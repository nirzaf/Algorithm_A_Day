namespace Algorithm_A_Day.Sorting.MergeSort
{
    public class MsWith2Arrays
    {
        public static void MergeSort2(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r)  / 2;

                MergeSort2(arr, l, m);
                MergeSort2(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            var l = new int[n1];
            var r = new int[n2];

            for (i = 0; i < n1; i++)
            {
                l[i] = arr[l + i];
            }
            
            for (j = 0; j < n2; j++)
            {
                r[j] = arr[m + 1 +j];
            }
            i = 0;
            j = 0;
            k = l;

            while(i < n1 && j < n2)
            {
                if(l[i] <= r[j])
                {
                    arr[k] = l[i];
                    i++;
                }
                else
                {
                    arr[k] = r[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = l[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = r[j];
                j++;
                k++;
            }
        }
    }
}
