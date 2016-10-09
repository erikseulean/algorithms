using System.Collections.Generic;

namespace SortingProblems
{
    public class Merge
    {
        public void MergeArray(ref int[] a, int[] b)
        {
            int[] extra = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;

            for (int k = 0; k < extra.Length; k++)
            {
                if (j != b.Length && a[i] > b[j])
                {
                    extra[k] = b[j];
                    j++;
                }
                else
                {
                    extra[k] = a[i];
                    i++;
                }
            }

            a = extra;
        }

        public void MergeArrayNoExtraMemory(ref int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            while (j != b.Length)
            {
                if (a[i] < b[j])
                    i++;
                else
                {
                    for (int k = a.Length - 1; k > i; k--)
                        a[k] = a[k - 1];
                    a[i] = b[j];
                    j++;
                }
            }
        }
    }
}
